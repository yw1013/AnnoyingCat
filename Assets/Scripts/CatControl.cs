using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatControl : MonoBehaviour {

    Animator anim;
    Rigidbody rb;

	// Use this for initialization
	void Start () {
        anim = this.GetComponent<Animator>();
        rb = this.GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetButton("Horizontal")) {
            var x = Input.GetAxis("Horizontal") * Time.deltaTime * 150.0f;
            transform.Rotate(0, x, 0);
        }

        if (Input.GetButtonDown("Vertical"))
        {
            anim.SetFloat("vert", 1f);
        }

        if (Input.GetButton("Vertical"))
        {
            var z = Input.GetAxis("Vertical") * Time.deltaTime * 3.0f;
            transform.Translate(0, 0, z);
        }

        if (Input.GetButtonUp("Vertical")) {
            anim.SetFloat("vert", 0f);
        }

        if (Input.GetButtonDown("Fire1")) {
            Vector3 dir = this.transform.position;
            anim.SetTrigger("atk");
            dir = -dir.normalized;
            //rb.AddForce(dir * 1000);
        }

        if (Input.GetButtonDown("Jump"))
        {
            anim.SetTrigger("jump");
            rb.AddForce(transform.up * 200);
        }

	}

	private void OnCollisionEnter(Collision collision)
	{
        if (collision.gameObject.name == "Test_Mouse") {
            anim.SetTrigger("caught");
        }
	}
}
