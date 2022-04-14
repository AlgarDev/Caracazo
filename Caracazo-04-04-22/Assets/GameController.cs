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
    [SerializeField]
    public Text gameOver;
    [SerializeField]
    public Text DialogText;
    [SerializeField]
    public Text UIText;
    [SerializeField]
    public Image DialogImage;
    [SerializeField]
    public Image UIImage;
   
  

    private void Awake()
    {
        gameOver.enabled = false;
        DialogText.enabled = false;
        UIText.enabled = false;
        DialogImage.enabled = false;
        UIImage.enabled = false;
        //DialogCanvas.enabled = false;
        //GameOverCanvas.enabled = false;

    }
}
