using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class cmove : MonoBehaviour
{
    public float speed;
    private float moveInput;
    private bool facingRight = true;
    public Animator anim;
    private Rigidbody2D rb;

    public int catEnd = 0;
    public void Start()
    {
        PlayerPrefs.SetInt("catEnd", 0);
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }
    private void FixedUpdate()
    {

        moveInput = Input.GetAxis("Horizontal1");
        rb.velocity = new Vector2(moveInput * speed, rb.velocity.y);


        if (facingRight == false && moveInput > 0)
        {
            Flip();
        }
        else if (facingRight == true && moveInput < 0)
        {
            Flip();
        }
        if(moveInput != 0)
        {
            anim.Play("CatWalk");
        }
        else
        {
            anim.Play("CatStay");
        }
    }
    void OnTriggerEnter2D(Collider2D catEnd)
    {
        if (catEnd.gameObject.tag == "catEnd")
        {
            PlayerPrefs.SetInt("catEnd", 1);
        }
    }
    void OnCollisionEnter2D(Collision2D enemy)
    {
        if (enemy.gameObject.tag == "enemy")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
    void Flip()
    {
        facingRight = !facingRight;
        Vector3 Scaler = transform.localScale;
        Scaler.x *= -1;
        transform.localScale = Scaler;

    }
}
