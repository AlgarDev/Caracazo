using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PuzzleScript : MonoBehaviour
{
    [SerializeField]
    private Canvas UICanvas;
    [SerializeField]
    private Text textMessage = null;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Box"))
        {
            UICanvas.enabled = true;
            textMessage.text = "hello";
            Debug.Log("good job");
        }
        

    }

}
