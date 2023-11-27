using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Android;

public class scrPlayer : MonoBehaviour
{
    Rigidbody2D rbPlayer;
    public float horizontal;
    public float vertical;
    public float velocidade = 10.0f;
    Animator animator;


    // Start is called before the first frame update
    void Start()
    {
        rbPlayer = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }
    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");

        if (horizontal > 0)
        {
            animator.SetBool("Right", true);
        }
        else
        {
            animator.SetBool("Right", false);
        }

        if (horizontal < 0)
        {
            animator.SetBool("Left", true);

        }
        else
        {
            animator.SetBool("Left", false);

        }

        if (vertical > 0)
        {
            animator.SetBool("Up", true);
        }
        else
        {
            animator.SetBool("Up", false);

        }

        if (vertical < 0)
        {
            animator.SetBool("Down", true);
        }
        else
        {
            animator.SetBool("Down", false);

        }
    }

    private void FixedUpdate()
    {
        rbPlayer.velocity = new Vector2(horizontal * velocidade, vertical * velocidade);
    }

}
