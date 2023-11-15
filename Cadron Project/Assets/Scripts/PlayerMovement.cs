using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D body;
    public float horizontal;
    public float vertical;

    private Animator animator;
    private SpriteRenderer spriteRenderer;

    private AudioSource walking;
    
    private float moveLimiter = 0.7f;

    public float runSpeed = 5f;

    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        walking = GetComponent<AudioSource>();
    }
    
    // Update is called once per frame
    void Update()
    {
        if(GameManager.Instance.IsPaused() == false)
        {
           horizontal = Input.GetAxisRaw("Horizontal");
            animator.SetFloat("horizontal", horizontal);
            vertical = Input.GetAxisRaw("Vertical");
            animator.SetFloat("vertical", vertical);
            if (horizontal < 0)
            {
                spriteRenderer.flipX = true;
            }
            else if(horizontal > 0)
            {
                spriteRenderer.flipX = false;
            }
            if(horizontal != 0 || vertical != 0){
                if(!walking.isPlaying){
                    walking.Play();
                }
                
            }
            else{
                walking.Stop();
            }

        }
    }

    void FixedUpdate() {
        if (horizontal != 0 && vertical != 0) {
            animator.SetFloat("horizontal", horizontal);
            animator.SetFloat("vertical", vertical);
            horizontal *= moveLimiter;
            vertical *= moveLimiter;
            
        }
        
        body.velocity = new Vector2(horizontal * runSpeed, vertical * runSpeed);
    }
    
}
