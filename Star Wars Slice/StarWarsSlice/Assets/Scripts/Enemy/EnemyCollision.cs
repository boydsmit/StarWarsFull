using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCollision : MonoBehaviour {

    [SerializeField]
    private int _health;

    private void OnCollisionEnter(Collision collision)
    {
        //If the object hits a wall or anything else but a bullet kill the object
        if (collision.gameObject.tag != "EnemyBullet")
        {
            _health =- 3;
        }
        //If hit by an bullet of the player remove 1 hp of the object
        if(collision.gameObject.tag == "PlayerBullet")
        {
            _health--;
        }

        //If the health is 0 kill the object
        if (_health <= 0)
        {
            Destroy(gameObject);
        }
    }
}
