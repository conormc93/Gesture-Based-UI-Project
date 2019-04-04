using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PowerUp : MonoBehaviour
{
    public int Speed = 60;

    void OnTriggerEnter2D(Collider2D collider){

        if (collider.CompareTag("Player")){
            PickUp();
        }
    }

    void PickUp(){

        Debug.Log("Power Up");
        Player.speed = Speed;

        Destroy(gameObject);
    }

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
