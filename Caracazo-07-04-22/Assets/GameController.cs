using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    [SerializeField]
    public Canvas GameOverCanvas;
    [SerializeField]
    public Canvas DialogCanvas;
  

    private void Awake()
    {
        DialogCanvas.enabled = false;
        //GameOverCanvas.enabled = false;

    }
}
