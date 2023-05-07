using UnityEngine;
using UnityEngine.UI;

public class mission : MonoBehaviour
{
    public GameObject intText, note, mainMission, mainKey, lazes;
    public Animator doorAnim;
    public bool interactable, toggle;
    public SC_FPSController playerScript;
    public Text mainMissionText;
    private bool firstTime = true;
    public int itemcollect;
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
        if (itemcollect == 10)
        {
            lazes.SetActive(false);
        }
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
                    note.SetActive(true);
                }
                else
                {
                    Time.timeScale = 1;
                    playerScript.enabled = true;
                    Cursor.visible = false;
                    Cursor.lockState = CursorLockMode.Locked;
                    note.SetActive(false);
                    if (firstTime == true)
                    {
                        mainMissionText.text = "Mission: Collect 10 memory pieces (" + itemcollect + "/10)";
                        mainMission.SetActive(true);
                        mainKey.SetActive(false);
                        doorAnim.SetTrigger("open");
                        firstTime = false;
                    }
                }
            }
        }
        if (firstTime == false)
        {
            mainMissionText.text = "Mission: Collect 10 memory pieces (" + itemcollect + "/10)";
        }
    }
}
