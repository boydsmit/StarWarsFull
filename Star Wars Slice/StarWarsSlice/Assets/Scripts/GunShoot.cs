using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunShoot : MonoBehaviour {

	[SerializeField]private GameObject Bullet;
	[SerializeField]private float timerDur;
	private bool pTimer = false;

	private void Update ()
	{
		if (Input.GetKey (KeyCode.Space) && pTimer == false || Input.GetMouseButton (0) && pTimer == false) 
		{
            
			StartCoroutine ("pShoot");
		}
	}
		
	IEnumerator pShoot()
	{
		pTimer = true;
        Instantiate(Bullet, new Vector3(transform.position.x, transform.position.y, transform.position.z), transform.rotation);
        yield return new WaitForSeconds (timerDur);
		pTimer = false;
	}

}
