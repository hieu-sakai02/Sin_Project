using UnityEngine;

public class doorPasscode : MonoBehaviour
{
    public GameObject intText, keypad;
    public bool interactable, toggle, opened = false;
    public Animator doorAnim;
    public SC_FPSController playerScript;

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
                if (opened == true)
                {
                    toggle = !toggle;
                    if (toggle == true)
                    {
                        doorAnim.ResetTrigger("close");
                        doorAnim.SetTrigger("open");
                    }
                    if (toggle == false)
                    {
                        doorAnim.ResetTrigger("open");
                        doorAnim.SetTrigger("close");
                    }
                    intText.SetActive(false);
                    interactable = false;
                }
                else
                {
                    toggle = !toggle;
                    if (toggle == true)
                    {
                        Time.timeScale = 0;
                        playerScript.enabled = false;
                        Cursor.visible = true;
                        Cursor.lockState = CursorLockMode.None;
                        keypad.SetActive(true);
                    }
                    else
                    {
                        Time.timeScale = 1;
                        playerScript.enabled = true;
                        Cursor.visible = false;
                        Cursor.lockState = CursorLockMode.Locked;
                        keypad.SetActive(false);
                        intText.SetActive(false);
                    }
                }
            }
        }
    }
}
