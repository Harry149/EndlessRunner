using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController2 : MonoBehaviour
{

    public float movespeed = 5f;
    public float jumpforce = 10f;
    public Transform groundCheckPoint;
    public float checkRadius = 0.2f;
    public LayerMask groundLayer;

    private Rigidbody2D rb;
    private bool isground;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {


        rb.velocity = new Vector2(movespeed, rb.velocity.y);

        isground = Physics2D.OverlapCircle(groundCheckPoint.position, checkRadius, groundLayer);

        if (isground && Input.GetKeyDown(KeyCode.Space))
        {
            jump();
        }
    }

    private void jump()
    {
        rb.velocity = new Vector2(rb.velocity.x, jumpforce);
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(groundCheckPoint.position, checkRadius);
    }
}
