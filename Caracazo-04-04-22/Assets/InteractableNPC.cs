using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.Events;
public class InteractableNPC : MonoBehaviour
{
    [SerializeField]
    private Text textMessage;
    [SerializeField]
    private Canvas myCanvas;
    [SerializeField]
    public UnityEvent Player;
    [SerializeField]
    private string text;
    [SerializeField]
    private Image textBox;
    [SerializeField]
    public UnityEvent Talking;
    public void Interact()
    {
        Player.Invoke();
        myCanvas.enabled = true;
        textMessage.enabled = true;
        textBox.enabled = true;
        Talking.Invoke();
        textMessage.text = text;

    }
}
