using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BonusPoints : MonoBehaviour {

    void OnTriggerEnter2D(Collider2D collider){

        if (collider.CompareTag("Player")){
            PickUp();
        }    
    }

    void PickUp(){

        Debug.Log("Power Up");
        IncreaseScore();
        Destroy(gameObject);
    }

    void IncreaseScore(){

        var scoreText = GameObject.Find("Score").GetComponent<Text>();

        int score = int.Parse(scoreText.text);
        score += 1;

        scoreText.text = score.ToString();

    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
