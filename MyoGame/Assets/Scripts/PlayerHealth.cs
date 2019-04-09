using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    //Constants and Variables
    public static int health;
    public int numOfHearts;
    //Images array to store hearts
    public Image[] hearts;
    public Sprite fullHeart;
    public Sprite emptyHeart;

    public void Update()
    {

        if (health > numOfHearts)
        {
            health = numOfHearts;
        }

        //loop as long as i is less than number of hearts in heart array
        for (int i = 0; i < hearts.Length; i++)
        {
            if (i < health)
            {

                hearts[i].sprite = fullHeart;
            }
            else
            {

                hearts[i].sprite = emptyHeart;
            }

            //if i is smaller than the number of hearts
            if (i < numOfHearts)
            {
                //Heart of index i to be visable

                
                    hearts[i].enabled = true;
                
            }
            else
            {
                //if i is bigger, than those hearts to be hidden
                hearts[i].enabled = false;
            }
        }
    }
}
