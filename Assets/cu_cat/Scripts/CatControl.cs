using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatControl : MonoBehaviour {

    Animator anim;
    Rigidbody rb;
    private bool isGrounded;
    private bool shiftPressed;
    private bool isTurning;
    public float speed = 1.6f;
    public float jumpableGroundNormalMaxAngle = 45f;
    public bool closeToJumpableGround;

	// Use this for initialization
	void Start () {
        anim = this.GetComponent<Animator>();
        rb = this.GetComponent<Rigidbody>();
        isGrounded = false;
        shiftPressed = false;
        isTurning = false;
        anim.SetBool("isGrounded", isGrounded);
	}
	
	// Update is called once per frame
	void Update () {

        //onCollisionStay() doesn't always work for checking if the character is grounded from a playability perspective
        //Uneven terrain can cause the player to become technically airborne, but so close the player thinks they're touching ground.
        //Therefore, an additional raycast approach is used to check for close ground
        if (CharacterCommon.CheckGroundNear(this.transform.position, jumpableGroundNormalMaxAngle, 0.1f, 1f, out closeToJumpableGround))             isGrounded = true;

        //Horizontal
        if (Input.GetButtonDown("Horizontal"))
        {
            isTurning = true;
            anim.SetBool("turn", isTurning);
        }


        if (Input.GetButton("Horizontal")) {
            var x = Input.GetAxis("Horizontal") * Time.deltaTime * 150f;
            transform.Rotate(0, x, 0);
        }

        if (Input.GetButtonUp("Horizontal"))
        {
            isTurning = false;
            anim.SetBool("turn", isTurning);
        }

        //Shift
        if (Input.GetButtonDown("Shift"))
        {
            shiftPressed = true;
            anim.SetBool("shift", shiftPressed);
        }

        if (Input.GetButtonUp("Shift"))
        {
            shiftPressed = false;
            anim.SetBool("shift", shiftPressed);
        }

        //Vertical
        if (Input.GetButtonDown("Vertical"))
        {
            anim.SetFloat("vert", 1f);

        }

        if (Input.GetButton("Vertical"))
        {
            if (shiftPressed)
            {
                speed = 1.9f;
            }
            else
            {
                speed = 1.1f;
            }
            var z = Input.GetAxis("Vertical") * Time.deltaTime * speed;
            transform.Translate(0, 0, Mathf.Abs(z));
        }

        if (Input.GetButtonUp("Vertical")) {
            anim.SetFloat("vert", 0f);
        }

        //Other Functions
        if (Input.GetKeyDown(KeyCode.C))
        {
            anim.SetTrigger("cry");
        }

        if (Input.GetButtonDown("Fire1")) {
            Vector3 dir = this.transform.position;
            anim.SetTrigger("atk");
            dir = -dir.normalized;
            //rb.AddForce(dir * 1000);
        }

        if (Input.GetButtonDown("Jump"))
        {
            if (isGrounded)
            {
                anim.SetTrigger("jump");
                rb.AddForce(transform.up * 200);
            }
        }

        anim.SetBool("isGrounded", isGrounded);
        isGrounded = false;

	}

	private void OnCollisionEnter(Collision collision)
	{
        if (collision.gameObject.tag == "mouse") {
            anim.SetTrigger("caught");
            Destroy(collision.gameObject);
        }
	}

    void OnCollisionStay(Collision collision)     {         isGrounded = true;
		if (anim != null) {
			anim.SetBool ("isGrounded", isGrounded);
		}     }
}
