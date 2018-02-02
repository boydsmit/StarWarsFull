using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFollowTarget : MonoBehaviour
{

    [SerializeField]
    private GameObject _targetToFollow;
    [SerializeField]
    private int _enemyMoveSpeed;

    private void Update()
    {
        gameObject.transform.LookAt(_targetToFollow.transform);
        transform.position += transform.forward * Time.deltaTime * _enemyMoveSpeed;
    }
}   