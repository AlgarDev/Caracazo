using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class Detection : MonoBehaviour
{
    [SerializeField]
    private UnityEvent player;

    [SerializeField]
    private Text gameOverText;

    [SerializeField]
    private Canvas myCanvas;

    [SerializeField]
    private float detectionTime = 5;
    [SerializeField]
    private float initialTime;

    private Coroutine playerDetectionCoroutine = null;

    [SerializeField]
    private Image detectionBar = null;

    [SerializeField]
    private bool beingDetected;

    [SerializeField]
    private float fillDetectionBar;

    [SerializeField]
    private float time;
    [SerializeField]
    private Text myGameOver;

    private void Start()
    {
        detectionBar.fillAmount = 0;
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        initialTime = Time.time;

        playerDetectionCoroutine = StartCoroutine(DetectionTimer());
       beingDetected = true;
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        StopCoroutine(playerDetectionCoroutine);
        beingDetected = false;
    }
    private void Update()
    {

        time = Time.time;
        if(beingDetected)
        {
            fillDetectionBar = (Time.time - initialTime)/detectionTime;
            
        }

        if (fillDetectionBar > 0 && beingDetected == false)
        {
            fillDetectionBar = fillDetectionBar - Time.deltaTime;

        }

        if (fillDetectionBar < 0)
        {
            fillDetectionBar = 0;
        }
        detectionBar.fillAmount = fillDetectionBar;
    }
    private void GameOver()
    {
        myCanvas.enabled = true;
        myGameOver.enabled = true;
        gameOverText.text = "Game Over";
        player.Invoke();
        Time.timeScale = 0;
    }
    private IEnumerator DetectionTimer()
    {
        yield return new WaitForSeconds(detectionTime);

        GameOver();
    }
}
