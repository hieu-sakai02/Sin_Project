using UnityEngine;

public class basicTrigger : MonoBehaviour
{
    public GameObject trigger;

    public void OnTriggerEnter(Collider other)
    {
        trigger.SetActive(true);
        gameObject.SetActive(false);
    }
}
