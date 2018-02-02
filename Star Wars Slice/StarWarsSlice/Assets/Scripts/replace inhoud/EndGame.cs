using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGame : MonoBehaviour {

	public GameObject Player;
	[SerializeField]
	int EndTime;

	private PlayerHealth health;

	void Start()
	{
		health = Player.GetComponent<PlayerHealth>();
	}

	void Update() {
		if(GameObject.FindGameObjectWithTag("CheckPoint") == null)
		{
			print ("checkpoint");
			StartCoroutine("EndTimer");


		}

		if (health.health <= 0)
		{
			StartCoroutine("EndTimer");
		}
	}

	IEnumerator EndTimer()
	{
		print("Timer Start");
		yield return new WaitForSeconds(EndTime);
		SceneManager.LoadScene(0);
	}

}
