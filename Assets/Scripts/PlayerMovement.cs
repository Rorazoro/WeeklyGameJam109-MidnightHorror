using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float speed = 5f;

    public float multiplyer = 100f;

    public float xInput;

    private Rigidbody2D rb;

    Animator animator;

    public bool isGrounded;

    public float jumpForce;
    private float jumpForceScript;

    private float jumpTimeCounter;
    public float jumpTime;

    public AudioSource jumpOnNormalSound;

    private Vector3 startingScale;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();

        startingScale = transform.localScale;
    }

    // Update is called once per frame
    void Update()
    {
        jumpForceScript = jumpForce;

        xInput = Input.GetAxisRaw("Horizontal");

        rb.velocity = new Vector2(xInput * speed * multiplyer * Time.deltaTime, rb.velocity.y);

        if (isGrounded == true && Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity = Vector2.up * jumpForceScript;
            jumpTimeCounter = jumpTime;
        }

        if (isGrounded == false && (Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.DownArrow)))
        {
            rb.velocity = Vector2.down * jumpForceScript;
            jumpTimeCounter = jumpTime;
        }

        //if (Input.GetKey(KeyCode.Space))
        //{
            //if (jumpTimeCounter > 0)
            //{
                // rb.velocity = Vector2.up * jumpForceScript;
                //jumpTimeCounter -= Time.deltaTime;
            //}

        //}

        if (xInput == 1)
        {
            transform.localScale = new Vector3(-startingScale.x, startingScale.y, startingScale.z);
        }
        else if (xInput == -1)
        {
            transform.localScale = new Vector3(startingScale.x, startingScale.y, startingScale.z);
        }
        animator.SetFloat("Speed", Mathf.Abs(xInput));
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.layer == 8)
        {
            isGrounded = true;
        }
    }

    void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.layer == 8)
        {
            isGrounded = false;
        }
    }

    void OnCollisionStay2D(Collision2D other)
    {
        if (Input.GetKey(KeyCode.Space) && other.gameObject.layer == 8)
        {
            jumpOnNormalSound.Play();
        }
        if (other.gameObject.layer == 8)
        {
            isGrounded = true;
        }
    }
}
