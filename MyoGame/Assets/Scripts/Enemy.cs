using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

    public float speed = 30;
    public Rigidbody2D rigidBody;

    void OnCollisionEnter2D(Collision2D col){
        if (col.gameObject.name == "VerticalWallRight"){
            Turn(-1);
            print("2");
        }
        if (col.gameObject.name == "VerticalWallLeft"){
            Turn(1);
        }
    }
    
    void Turn(int direction) {
        Vector2 Velocity = rigidBody.velocity;
        Velocity.x = speed * direction;
        rigidBody.velocity = Velocity;
    }

	// Use this for initialization
	void Start () {
        rigidBody = GetComponent<Rigidbody2D>();
        rigidBody.velocity = new Vector2(1, 0) * speed;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
