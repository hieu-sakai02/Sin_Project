using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class mission_trigger_hall : MonoBehaviour
{
	public GameObject mission, dialog;
	public string missionString, dialogString;
	public float screamTime;
	public Text missionText, dialogText;
	public AudioSource scream;

	public void OnTriggerEnter(Collider other)
	{
		missionText.text = "Mission: " + missionString;
		dialogText.text = dialogString;
		scream.Play();
		dialog.SetActive(true);
		StartCoroutine(cutscene());
	}

	IEnumerator cutscene()
	{
		yield return new WaitForSeconds(screamTime);
		dialog.SetActive(false);
		mission.SetActive(true);
		Destroy(gameObject);
	}

}
