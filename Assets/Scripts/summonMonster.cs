using UnityEngine;
using UnityEngine.UI;

public class summonMonster : MonoBehaviour
{
    public GameObject monster, block1, block2, block3, mission;
    public Collider collision;
    public bool blocks;
    public string missionString;
    public Text missionText;
    public AudioSource chaseSound;


    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            monster.SetActive(true);
            chaseSound.Play();

            if (blocks == true)
            {
                block1.SetActive(true);
                block2.SetActive(true);
                block3.SetActive(false);
            }
            missionText.text = missionString;
            mission.SetActive(true);
            collision.enabled = false;
        }
    }
}
