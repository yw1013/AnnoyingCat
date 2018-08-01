using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DogAI : MonoBehaviour {
	Animator anim;
	public Transform Player;
	int MaxDist = 10;
	int MinDist = 3;
	int MoveSpeed = 4;

	bool hasSeenCat = false;
	bool hasAttacked = false;

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator>();
		anim.SetFloat("Speed", 0f);
	}

	// Update is called once per frame
	void Update () {
		if (!hasAttacked) {
			transform.LookAt(Player);
		}

		if (!hasAttacked && !hasSeenCat && Vector3.Distance(transform.position, Player.position) <= 3)
		{
			hasSeenCat = true;
		}

		if (!hasAttacked && hasSeenCat && (Vector3.Distance(transform.position, Player.position) <= 5) && (Vector3.Distance(transform.position, Player.position) >= 3)) {
			anim.SetFloat("Speed", 1f);
			transform.position += transform.forward * MoveSpeed / 4 * Time.deltaTime;
		}

		if (!hasAttacked && hasSeenCat && Vector3.Distance(transform.position, Player.position) <= 3 && Vector3.Distance(transform.position, Player.position) >= 0.3) {
			anim.SetFloat("Speed", 3f);
			transform.position += transform.forward * MoveSpeed * Time.deltaTime;
		}

		if (!hasAttacked && hasSeenCat && Vector3.Distance(transform.position, Player.position) < 0.3) {
			transform.position += transform.forward * MoveSpeed * Time.deltaTime;
			anim.SetTrigger("Jump");
			hasAttacked = true;
		}

		if (hasAttacked) {
			 anim.SetFloat("Speed", 0f);
		}
	}


}
