using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

    public float speed = 30;
    public Rigidbody2D rigidBody;
    public GameObject enemyBullet;

    public float minFireRateTime = 1.0f;
    public float maxFireRateTime = 3.0f;
    public float baseFireWaitTime = 3.0f;

    public float minDropRateTime = 1.0f;
    public float maxDropRateTime = 3.0f;
    public float baseDropWaitTime = 3.0f;
    public GameObject powerUp;

    void OnCollisionEnter2D(Collision2D col){
        if (col.gameObject.name == "VerticalWallRight"){
            Turn(-1);
            Advance();
            print("2");
        }
        if (col.gameObject.name == "VerticalWallLeft"){
            Turn(1);
            Advance();
        }
    }
    
    void Turn(int direction) {
        Vector2 Velocity = rigidBody.velocity;
        Velocity.x = speed * direction;
        rigidBody.velocity = Velocity;
    }

    void Advance(){
        Vector2 position = transform.position;
        position.y -= 1;
        transform.position = position;
    }

	// Use this for initialization
	void Start () {
        rigidBody = GetComponent<Rigidbody2D>();
        rigidBody.velocity = new Vector2(1, 0) * speed;

        baseFireWaitTime = baseFireWaitTime + Random.Range(minFireRateTime, maxFireRateTime);
	}

    void FixedUpdate(){

        if (Time.time > baseFireWaitTime){
            baseFireWaitTime = baseFireWaitTime + Random.Range(minFireRateTime, maxFireRateTime);

            Instantiate(enemyBullet, transform.position, Quaternion.identity);
            AudioManager.audioManager.PlayOneShot(AudioManager.audioManager.alienBlast);

        }
        if(Time.time > baseDropWaitTime){
            baseDropWaitTime = baseDropWaitTime + Random.Range(minDropRateTime, maxDropRateTime);

            Instantiate(powerUp, transform.position, Quaternion.identity);
            
        }
    }

    // Update is called once per frame
    void Update () {
		
	}
}
