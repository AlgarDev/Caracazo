using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.Events;
public class InteractableNPC : MonoBehaviour
{
    [SerializeField]
    private Text textMessage = null;
    [SerializeField]
    private Canvas myCanvas;
    [SerializeField]
    public UnityEvent Player;
    [SerializeField]
    private string text = null;
    public void Interact()
    {
        Player.Invoke();
        myCanvas.enabled = true;
        textMessage.text = text;

    }
}
