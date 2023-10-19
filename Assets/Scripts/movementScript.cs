using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movementScript : MonoBehaviour
{
    public Rigidbody2D rb;
    private Animator animator;
    public float forceAmount = 1500;
    public bool canJump = false;
    public GameObject player;
    private SpriteRenderer _renderer;
    public AudioSource jumpSound;
    public AudioSource failSound;

    public float distanceAllowedToFall = 15f;

    public float jumpHeight;
    public float landingHeight;
    public float fallDistance;

    public AudioSource fallSound;
    public AudioSource contactSound;
    public float health = 1;
    public bool canFlip = true;
    
    [SerializeField] private healthControl healthBar;

    void Start()
    {
        Application.targetFrameRate = 60;
        _renderer = GetComponent<SpriteRenderer>();
        if (_renderer == null)
        {
            Debug.LogError("Player Sprite is missing a renderer");
        }
        animator = GetComponent<Animator>();
        
      
    }
    void Update()
    {
        
        if (health <= 0)
        {
            canFlip = false;
            canJump = false;
           
            animator.SetBool("dead", true);
            
        }
        if (Input.GetMouseButton(0) && canJump)
        {
            forceAmount++;
            
            if (forceAmount > 3000)
                forceAmount = 3000;
            
        }

       if (Input.GetMouseButtonUp(0) && canJump)
        {
            Vector3 posInScreen = Camera.main.WorldToScreenPoint(transform.position);
           
            Vector3 dirToMouse = Input.mousePosition - posInScreen;
            dirToMouse.Normalize();

            GetComponent<Rigidbody2D>().AddForce(dirToMouse * forceAmount);
            forceAmount = 1500;
            jumpSound.Play();
            animator.SetBool("fell", false);
            animator.SetTrigger("takeoff");
        }
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        if (mousePos.x > transform.position.x && canFlip)
        {
            _renderer.flipX = false;
        }
        else
        {
            _renderer.flipX = true;
        }
        healthBar.setSize(health);

    }
    public void OnCollisionStay2D(Collision2D obj)
    {
        canJump = true;
        
        animator.SetBool("isJumping", false);
    }
    void OnCollisionExit2D(Collision2D obj)
    {
        canJump = false;
       animator.SetBool("isJumping", true);
       jumpHeight = transform.position.y;
    }
    void OnCollisionEnter2D(Collision2D other)
    {
        landingHeight = transform.position.y;
        HealthDrain();
        rb.velocity = new Vector2(0f, 0f);

    }
    void HealthDrain()
    {
        fallDistance = jumpHeight - landingHeight;

        if (fallDistance > distanceAllowedToFall)
        {
            fallSound.Play();
            animator.SetBool("fell", true);
            
            health -= .25f;
            healthBar.setSize(health);
            if (health <= 0) 
            {
                levelManager.instance.GameOver();
                failSound.Play();
            }
        }
        else
        {
            contactSound.Play();
        }
    }
}


