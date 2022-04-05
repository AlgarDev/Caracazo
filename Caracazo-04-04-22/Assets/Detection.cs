using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class Detection : MonoBehaviour
{
    [SerializeField]
    private UnityEvent Player;

    [SerializeField]
    private Text GameOver;

    [SerializeField]
    private Canvas myCanvas;

    private void OnTriggerEnter2D(Collider2D other)
    {
        myCanvas.enabled = true;
        GameOver.text = "Game Over";
        Player.Invoke();
        Time.timeScale = 0;
    }
    private void Update()
    {
        
    }
}
