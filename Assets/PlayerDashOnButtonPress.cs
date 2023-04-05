using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDashOnButtonPress : MonoBehaviour
{
    public float dashSpeed = 10f;
    public float dashTime = 0.5f;
    public float dashCooldown = 1f;
    public float dashCooldownTimer = 0f;
    public float dashTimer = 0f;
    public bool isDashing = false;
    public bool canDash = true;
    public Rigidbody rb;
    public Vector3 dashDirection;

    public AudioSource dashSound;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();

    }
    void FixedUpdate()
    {
        if (isDashing)
        {
            if (dashTimer > 0)
            {
                rb.velocity = dashDirection * dashSpeed;
                dashTimer -= Time.deltaTime;
                // todo: optimize this
            }
            else
            {
                isDashing = false;
            }
        }
        else
        {
            if (dashCooldownTimer > 0)
            {
                dashCooldownTimer -= Time.deltaTime;
            }
            else
            {
                canDash = true;
            }
        }
    }

    void Update()
    {
        if (Input.GetAxis("Fire2") > 0 && canDash)
        {
            isDashing = true;
            canDash = false;
            dashTimer = dashTime;
            dashCooldownTimer = dashCooldown;
            dashDirection = transform.forward;
            dashSound.Play();
            GetComponent<SUPERCharacter.SUPERCharacterAIO>().InstantStaminaReduction(25f);
        }
        
    }
}
