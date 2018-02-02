using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField]
    private int _bulletSpeed;

    [SerializeField]
    private string _ignore;

    private void Update()
    {
       
        transform.position += transform.forward * Time.deltaTime * _bulletSpeed;
    }

    private void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.tag != _ignore)
        { 
           Destroy(gameObject);
        }
    }
}   