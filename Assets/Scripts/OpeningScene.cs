using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class OpeningScene : MonoBehaviour
{
    public GameObject cutsceneCam, player, dialogue;
    public float cutsceneTime;
    public float dialogueTime;
    public string dialogueString;
    public Text dialogueText;

    void Start()
    {
        StartCoroutine(cutscene());
    }

    IEnumerator cutscene()
    {
        yield return new WaitForSeconds(cutsceneTime);
        player.SetActive(true);
        cutsceneCam.SetActive(false);
        dialogueText.text = dialogueString;
        dialogue.SetActive(true);
        StartCoroutine(disableDialogue());
    }

    IEnumerator disableDialogue()
    {
        yield return new WaitForSeconds(dialogueTime);
        dialogue.SetActive(false);
    }
}
