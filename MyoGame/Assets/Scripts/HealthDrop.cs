using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthDrop : MonoBehaviour
{
    public int Health;
    private Transform player;
    public int increase = 1;

    void OnTriggerEnter2D(Collider2D collider)
    {

        if (collider.CompareTag("Player"))
        {
            
            PickUpHealth();
        }
    }

    void PickUpHealth()
    {
        player.SendMessage("IncreaseHealth", increase);
        Destroy(gameObject);
    }

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }


    // Update is called once per frame
    void Update()
    {

    }
}
