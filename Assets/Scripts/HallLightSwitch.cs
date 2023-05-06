using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HallLightSwitch : MonoBehaviour
{
    public GameObject inttext, light1, light2, light3, light4;
    public bool toggle, interactable;
    public Renderer lightBulb1, lightBulb2, lightBulb3, lightBulb4;
    public Material offlight, onlight;
    public AudioSource LighSwitchSound;
    public Animator switchAnim;

    void OnTriggerStay(Collider other)
    {
        inttext.SetActive(true);
        interactable = true;
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
        if(interactable == true)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                toggle = !toggle;
                //lightSwitchSound.Play();
                switchAnim.ResetTrigger("press");
                switchAnim.SetTrigger("press");
            }
        }
        if(toggle == false)
        {
            light1.SetActive(false);
            lightBulb1.material = offlight;
            light2.SetActive(false);
            lightBulb2.material = offlight;
            light3.SetActive(false);
            lightBulb3.material = offlight;
            light4.SetActive(false);
            lightBulb4.material = offlight;
        }
        if (toggle == true)
        {
            light1.SetActive(true);
            lightBulb1.material = onlight;
            light2.SetActive(true);
            lightBulb2.material = onlight;
            light3.SetActive(true);
            lightBulb3.material = onlight;
            light4.SetActive(true);
            lightBulb4.material = onlight;
        }
    }
}
