using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBullet : MonoBehaviour {

    public float speed = 30;
    public Rigidbody2D rigidBody;


	// Use this for initialization
	void Start () {
        rigidBody = GetComponent<Rigidbody2D>();
        rigidBody.velocity = Vector2.up * speed;
	}

    void OnTriggerEnter2D(Collider2D col){
        if (col.tag == "Wall"){
            Destroy(gameObject);
        }

        if(col.tag == "Enemy"){
            Destroy(gameObject);
            Destroy(col.gameObject, 0.5f);
        }
    }

    void OnBecomeInvisible(){
        Destroy(gameObject);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
