using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerBullet : MonoBehaviour {

    public float speed = 30;
    public Rigidbody2D rigidBody;
    public GameObject powerUp;


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
            IncreaseScore();
            AudioManager.audioManager.PlayOneShot(AudioManager.audioManager.enemyDeath);
        }
        if(col.tag == "BonusEnemy"){

            Destroy(gameObject);
            Destroy(col.gameObject, 0.5f);
            IncreaseScore();
            AudioManager.audioManager.PlayOneShot(AudioManager.audioManager.enemyDeath);
            Instantiate(powerUp, transform.position, Quaternion.identity);
        }
    }

    void OnBecomeInvisible(){
        Destroy(gameObject);
    }

    void IncreaseScore(){

        var scoreText = GameObject.Find("Score").GetComponent<Text>();

        int score = int.Parse(scoreText.text);
        score += 10;

        scoreText.text = score.ToString();

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
