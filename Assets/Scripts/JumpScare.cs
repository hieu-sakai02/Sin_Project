using UnityEngine;

public class JumpScare : MonoBehaviour
{
    public GameObject scare;
    public AudioSource scareSound;
    public Collider collision;
    public Animator jumpscareAnim;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            scare.SetActive(true);
            jumpscareAnim.ResetTrigger("trigger");
            jumpscareAnim.SetTrigger("trigger");
            scareSound.Play();
            collision.enabled = false;
        }
    }
}
