using UnityEngine;
using UnityEngine.UI;

public class pickupKey : MonoBehaviour
{
    public GameObject inttext, key, spookystuff, monstertrigger, mission;
    public AudioSource pickup;
    public bool interactable, scaryEvent;
    public string missionString;
    public Text missionText;

    void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("MainCamera"))
        {
            inttext.SetActive(true);
            interactable = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("MainCamera"))
        {
            inttext.SetActive(false);
            interactable = false;
        }
    }

    void Update()
    {
        if (interactable == true)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                monstertrigger.SetActive(true);
                inttext.SetActive(false);
                interactable = false;
                pickup.Play();
                if (scaryEvent == true)
                {
                    spookystuff.SetActive(true);
                }
                missionText.text = "Mission: " + missionString;
                key.SetActive(false);
            }
        }
    }

}
