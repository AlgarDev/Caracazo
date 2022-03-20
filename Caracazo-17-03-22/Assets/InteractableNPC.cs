using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class InteractableNPC : MonoBehaviour
{
    public void Interact()
    {
        Debug.Log("hello dumbfuck");
    }


   /* [SerializeField]
    private string[] thingToSay;
    [SerializeField]
    bool repeat = false;
    private int currentSpokenStrings = 0;
    private Text someTextPanel;

    void Awake()
    {
        someTextPanel = GetComponentInChildren<Text>();
    }

    public void Interact()
    {
        if (currentSpokenStrings < thingToSay.Length)
        {
            // Speak the string.. Probably using a 'Canvas Set To World Space'
            Speak(thingToSay[currentSpokenStrings]);
            currentSpokenStrings++;
        }
        else
        {
            if (repeat)
                currentSpokenStrings = 0;
        }
    }

    void Speak(string whatToSay)
    {
        // Make someTextPanel visible first, however you want to do that.. Maybe someTextPanel.gameObject.SetActive(true) and then set to false after some time?
        someTextPanel.text = whatToSay;
    }*/
}
