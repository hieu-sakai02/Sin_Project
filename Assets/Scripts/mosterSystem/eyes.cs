using System.Collections;
using UnityEngine;

public class eyes : MonoBehaviour
{
    public GameObject intText, eye, mainCam, monsCam;
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
                mainCam.SetActive(false);
                monsCam.SetActive(true);
                intText.SetActive(false);
                StartCoroutine("disableEye");
            }
        }
    }

    IEnumerator disableEye()
    {
        yield return new WaitForSeconds(4f);
        monsCam.SetActive(false);
        mainCam.SetActive(true);
        eye.SetActive(false);
    }
}
