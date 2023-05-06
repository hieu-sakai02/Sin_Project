using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class monsterJumpscare : MonoBehaviour
{
    public Animator monsterAnim;
    public GameObject player;
    public float jumpscareTime;
    public string sceneName;
    public monsterAI monsterscript;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            player.SetActive(false);
            monsterscript.enabled = false;
            monsterAnim.ResetTrigger("idle");
            monsterAnim.ResetTrigger("walk");
            monsterAnim.ResetTrigger("run");
            monsterAnim.SetTrigger("jumpscare");
            StartCoroutine(jumpscare());
        }
    }
    IEnumerator jumpscare()
    {
        yield return new WaitForSeconds(jumpscareTime);
        SceneManager.LoadScene(sceneName);
    }
}
