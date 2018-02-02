using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBar : MonoBehaviour {

    //HealthS == HealthScript
    private PlayerHealth _healthS;
    private SpriteRenderer _currentSprite;

    [SerializeField]
    private GameObject _player;

    [SerializeField]
    private Sprite[] _healthBarTexture;

    void Start () {

        _healthS = _player.GetComponent<PlayerHealth>();
        _currentSprite = GetComponent<SpriteRenderer>();
        
	}
	void Update () {
		switch((int)_healthS.health)
        {
            case 4:
                _currentSprite.sprite = _healthBarTexture[0];
                break;
       
            case 3:
                _currentSprite.sprite = _healthBarTexture[1];
                break;
            case 2:
                _currentSprite.sprite = _healthBarTexture[2];
                break;
            case 1:
                _currentSprite.sprite = _healthBarTexture[3];
                break;

            default:
                _currentSprite.sprite = _healthBarTexture[4];
                break;
        }
	}
}
