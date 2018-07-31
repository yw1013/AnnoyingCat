using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChaseCat : MonoBehaviour {
	public Transform Player;
	public Animator anim;
	float MoveSpeed = 4f;
	float MaxDist = 10f;
	float MinDist = 1f;

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator>();


	}

	// Update is called once per frame
	void Update ()
	{
			transform.LookAt(Player);

			anim.SetBool("Bark", true);

			// if (Vector3.Distance(transform.position, Player.position) >= MinDist)
			// {
			//
			// 		anim.SetFloat("Speed", MoveSpeed * Time.deltaTime);
			// 		transform.position += transform.forward * MoveSpeed * Time.deltaTime;
			//
			//
			//
			// 		if (Vector3.Distance(transform.position, Player.position) <= MaxDist)
			// 		{
			// 				//Here Call any function U want Like Shoot at here or something
			// 		}
			//
			// }
		}

}
