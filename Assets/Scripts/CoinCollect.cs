using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinCollect : MonoBehaviour
{
    private PlayerController2 playerController;
    void Start()
    {
        playerController = FindObjectOfType<PlayerController2>();
        
    }
    // Start is called before the first frame update
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            playerController.cscore = playerController.cscore + 30;
            print(playerController.cscore);
            Destroy(gameObject);
            
        }
    }
}
