using UnityEngine;

public class hiddenwall : MonoBehaviour
{
    public GameObject hiddenWall;

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            hiddenWall.SetActive(true);
            gameObject.SetActive(false);
        }
    }
}
