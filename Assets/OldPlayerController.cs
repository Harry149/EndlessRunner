using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{ 
    Rigidbody2D playerObject;
    public float Speed = 2.0f;
    // Start is called before the first frame update
    void Start()
    {
        

        playerObject = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {


        float movementValueX = Input.GetAxis("Horizontal");
        float movementValueY = Input.GetAxis("Vertical");

        playerObject.velocity = new Vector2 (movementValueX * Speed, movementValueY * Speed);
    }
}
