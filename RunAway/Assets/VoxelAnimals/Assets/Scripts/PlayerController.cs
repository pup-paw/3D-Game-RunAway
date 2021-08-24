using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float movementSpeed = 6;
    public float jumpForce = 1000;
    public float timeBeforeNextJump = 0.5f;
    private float canJump = 0f;
    public int maxHealth = 1;
    public int health { get { return currentHealth; } }
    int currentHealth;
    Animator anim;
    Rigidbody rb;
    
    void Start()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
        currentHealth = maxHealth;
    }

    void Update()
    {
        ControllPlayer();
    }

    public void ChangeHealth(int amount)
    {
        currentHealth = Mathf.Clamp(currentHealth + amount, 0, maxHealth);
        if(currentHealth == 0)
        {
            GameController.instance.GameOver();
        }
    }

    void ControllPlayer()
    {
        float moveHorizontal = Input.GetAxisRaw("Horizontal");
        float moveVertical = Input.GetAxisRaw("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        if (movement != Vector3.zero)
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(movement), 0.15f);
            anim.SetInteger("Walk", 1);
        }
        else {
            anim.SetInteger("Walk", 0);
        }

        transform.Translate(movement * movementSpeed * Time.deltaTime, Space.World);

        if (Input.GetButtonDown("Jump") && Time.time > canJump)
        {
                rb.AddForce(0, jumpForce, 0);
                canJump = Time.time + timeBeforeNextJump;
                anim.SetTrigger("jump");
        }
    }
}