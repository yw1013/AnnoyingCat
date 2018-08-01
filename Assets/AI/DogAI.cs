using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DogAI : MonoBehaviour {
	Animator anim;
	public Transform Player;
	int MaxDist = 10;
	int MinDist = 3;
	public float MoveSpeed = 0.6f;

	bool hasSeenCat = false;
	bool hasAttacked = false;
    bool halt = true;

    public ScoreManager scoreManager;
    public int scoreVal;
    private bool knocked;

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator>();
		anim.SetFloat("Speed", 0f);
        knocked = false;
	}

	// Update is called once per frame
	void Update () {
		if (!hasAttacked) {
			transform.LookAt(Player);
		}

		if (!hasAttacked && !hasSeenCat && Vector3.Distance(transform.position, Player.position) <= 0.7)
		{
			hasSeenCat = true;
            halt = false;
		}

		if (!halt && !hasAttacked && hasSeenCat && (Vector3.Distance(transform.position, Player.position) <= 5) && (Vector3.Distance(transform.position, Player.position) >= 3)) {
			anim.SetFloat("Speed", 1f);
			transform.position += transform.forward * MoveSpeed / 4 * Time.deltaTime;
		}

        if (!halt && !hasAttacked && hasSeenCat && Vector3.Distance(transform.position, Player.position) <= 3 && Vector3.Distance(transform.position, Player.position) >= 0.3) {
			anim.SetFloat("Speed", 3f);
			transform.position += transform.forward * MoveSpeed * Time.deltaTime;
		}

        if (!halt && !hasAttacked && hasSeenCat && Vector3.Distance(transform.position, Player.position) < 0.3) {
			transform.position += transform.forward * MoveSpeed * Time.deltaTime;
			anim.SetTrigger("Jump");
			hasAttacked = true;
		}

        if (!hasAttacked && hasSeenCat && Vector3.Distance(transform.position, Player.position) > 1) {
            halt = true;
        }

		if (hasAttacked) {
			 anim.SetFloat("Speed", 0f);
		}
	}

    private void OnCollisionEnter(Collision collision)
    {
        if (!knocked && !hasAttacked)
        {
            if (collision.gameObject.tag == "Player")
            {
                if (scoreManager != null)
                {
                    scoreManager.addScore(scoreVal);
                    knocked = true;
                }
            }
        }
    }


}
