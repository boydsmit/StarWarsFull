using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;



public class CheckpointScript : MonoBehaviour
{
	[SerializeField] private GameObject[] CheckPoints;
	[SerializeField] private Image[] CheckPointsImage;
	[SerializeField] private Sprite newImage;
	[SerializeField] private int EndTime;
	private int i = 0;

	private void OnTriggerEnter(Collider trigger)
	{
		print("grygrt");
		if (trigger.gameObject == CheckPoints[i])
		{
			CheckPointsImage[i].sprite = newImage;
			i++;
			Destroy(trigger.gameObject);
			if (i == CheckPoints.Length)
			{
				StartCoroutine("Fade");
			}
		}
	}




	private IEnumerator Fade()
	{
		print("start timer");
		yield return new WaitForSeconds(EndTime);
		SceneManager.LoadScene(0);
		//win game
		//SceneManager.LoadScene(1);
	}
}