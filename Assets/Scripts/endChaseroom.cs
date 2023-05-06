using UnityEngine;

public class endChaseroom : MonoBehaviour
{
    public GameObject wallChaseroom;

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            wallChaseroom.SetActive(true);
        }
    }
}
