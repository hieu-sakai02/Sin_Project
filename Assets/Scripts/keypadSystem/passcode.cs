using UnityEngine;
using UnityEngine.UI;

public class passcode : MonoBehaviour
{
    private string Code = "2512";
    private string Nr = null;
    private int NrIndex = 0;
    private string alpha;
    public Text UiText = null;
    public doorPasscode doorPasscode;
    public GameObject keypad;
    public SC_FPSController playerScript;

    public void Start()
    {
        UiText.text = Nr;
    }
    public void CodeFunction(string Numbers)
    {
        NrIndex++;
        Nr = Nr + Numbers;
        UiText.text = Nr;
    }

    public void Enter()
    {
        if (Nr == Code)
        {
            doorPasscode.opened = true;
            Time.timeScale = 1;
            playerScript.enabled = true;
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;
            keypad.SetActive(false);
        }
        else
        {
            Nr = null;
            NrIndex = 0;
            UiText.text = Nr;
        }
    }

    public void Remove()
    {
        NrIndex--;
        if (Nr != null)
        {
            Nr = Nr.Substring(0, Nr.Length - 1);
            UiText.text = Nr;
        }
    }
}
