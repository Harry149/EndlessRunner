using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController2 : MonoBehaviour
{

    public float movespeed = 5f;
    public float jumpforce = 10f;
    public Transform groundCheckPoint;
    public float checkRadius = 0.2f;
    public LayerMask groundLayer;
    public Text score;
    public GameObject player;

    private Rigidbody2D rb;
    private bool isground;

    public AudioClip Jump;
    public AudioSource sfxPlayer;
    Animator anim;
    bool DoubleJump = false;
    public float cscore = 0;
    float num = 0;
    bool active = false;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        //sfxPlayer = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        //num = (player.transform.position.x / 5);
        //cscore = cscore + (num / 1000);
        if (active == false)
        {
            StartCoroutine(scoretimer());
            active = true;
        }
        
        rb.velocity = new Vector2(movespeed, rb.velocity.y);
        isground = Physics2D.OverlapCircle(groundCheckPoint.position, checkRadius, groundLayer);
        anim.SetBool("IsOnGround", isground);
        if (isground && Input.GetKeyDown(KeyCode.Space))
        {
            DoubleJump = true;
            jump();
        }
        else if (DoubleJump == true && Input.GetKeyDown(KeyCode.Space))
        {
            jump();
            DoubleJump = false;
        }
    }

    private void jump()
    {
        sfxPlayer.PlayOneShot(Jump);
        rb.velocity = new Vector2(rb.velocity.x, jumpforce);
    }

    public void AddScore(float value)
    {
        if (player.transform.position.x > 0)
        {
            cscore += value;
            float scoree = cscore + value;
            score.text = cscore.ToString();
        }       
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(groundCheckPoint.position, checkRadius);
    }
    IEnumerator scoretimer()
    {
        yield return new WaitForSeconds(1);
        AddScore(1);
        active = false;

    }
}
