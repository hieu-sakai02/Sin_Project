using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class getPaper : MonoBehaviour
{
    public GameObject intText, readnote, dialogue;
    public bool interactable, toggle;
    public mission mission;
    public SC_FPSController playerScript;
    public Text noteText, dialogueText;
    public string dialogueString, noteString;
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
                toggle = !toggle;
                if (toggle == true)
                {
                    Time.timeScale = 0;
                    playerScript.enabled = false;
                    Cursor.visible = true;
                    Cursor.lockState = CursorLockMode.None;
                    noteText.text = noteString;
                    dialogueText.text = dialogueString;
                    readnote.SetActive(true);
                }
                else
                {
                    Time.timeScale = 1;
                    playerScript.enabled = true;
                    Cursor.visible = false;
                    Cursor.lockState = CursorLockMode.Locked;
                    readnote.SetActive(false);
                    mission.itemcollect++;
                    dialogue.SetActive(true);
                    intText.SetActive(false);
                    StartCoroutine("disableText");
                    MeshRenderer renderer = gameObject.GetComponent<MeshRenderer>();
                    renderer.enabled = false;
                }
            }
        }
    }
    IEnumerator disableText()
    {
        yield return new WaitForSeconds(4.0f);
        dialogue.SetActive(false);
        gameObject.SetActive(false);
    }
}
