using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public float speed = 20;

    void Move(){

        float moveHorizontal = Input.GetAxis("Horizontal");

        GetComponent<Rigidbody2D>().velocity = new Vector2(moveHorizontal, 0) * speed;

    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Move();
	}
}
