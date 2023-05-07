using UnityEngine;
using UnityEngine.UI;

public class key : MonoBehaviour
{
    public GameObject intText, iskey, dialogue;
    public Text dialogueText;
    public bool interactable, toggle;

    void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("MainCamera"))
        {
            intText.SetActive(true);
            interactable = true;
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("MainCamera"))
        {
            intText.SetActive(false);
            interactable = false;
        }
    }

    void Update()
    {
        if (interactable == true)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                dialogueText.text = "What is this key for?";
                dialogue.SetActive(true);
                intText.SetActive(false);
                Invoke("disabledText", 2f);
                iskey.SetActive(false);
            }
        }
    }

    void disabledText()
    {
        dialogue.SetActive(false);
    }
}
