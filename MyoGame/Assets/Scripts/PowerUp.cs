using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PowerUp : MonoBehaviour
{

    void OnTriggerEnter2D(Collider2D collider){

        if (collider.CompareTag("Player")){
            PickUp();
        }
    }

    void PickUp(){

        Debug.Log("Power Up");
        


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
