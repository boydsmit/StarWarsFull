using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShoot : MonoBehaviour
{
    [SerializeField]
    private GameObject _bullet;
    [SerializeField]
    private float _shootTimer;

    private bool eTimer = false;

    private void Update()
    {
        //Check for a bool so the Couroutine wont be spammed
        if (eTimer == false)
        {
            StartCoroutine("eShoot");
        }
    }

    //Shoot cooldown
    private IEnumerator eShoot()
    {
        eTimer = true;
        yield return new WaitForSeconds(_shootTimer);
        Instantiate(_bullet, new Vector3(transform.position.x, transform.position.y, transform.position.z), transform.rotation);
        eTimer = false;
    }
}