using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Flower : MonoBehaviour
{
    private int flower;
    public Text flowerCount;


    private void Start()
    {
        flower = 0;
    }

     void OnTriggerEnter2D(Collider2D pickup)
     {
        if (pickup.tag == "Flower")
        {
            flower++;
            flowerCount.text = "" + flower;
            Destroy(pickup.gameObject);
                 
        }
    }
}
