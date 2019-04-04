using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour {

    private Rigidbody2D rigidBody;

    public float speed = 30;

	// Use this for initialization
	void Start () {
        rigidBody = GetComponent<Rigidbody2D>();

        rigidBody.velocity = Vector2.down * speed;
	}
	
    void  OnTriggerEnter2D(Collider2D col){

        if(col.tag == "Wall"){
            Destroy(gameObject);
        }
        if(col.gameObject.tag == "Player"){
            Destroy(gameObject);
            Destroy(col.gameObject, 0.5f);
            AudioManager.audioManager.PlayOneShot(AudioManager.audioManager.playerDeath);
        }

    }

	// Update is called once per frame
	void Update () {
		
	}
}
