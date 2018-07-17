using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShatterByCat : MonoBehaviour {

    public GameObject shattered;
    public ScoreManager scoreManager;
    public int scoreVal;
    private bool knocked;

    // Use this for initialization
    void Start()
    {
        knocked = false;

    }

	private void OnCollisionEnter(Collision collision)
	{
        if (!knocked)
        {
            if (collision.gameObject.tag == "Player")
            {
                Instantiate(shattered, transform.position, transform.rotation);
                scoreManager.addScore(scoreVal);
                knocked = true;
                Destroy(gameObject);
            }
        }
	}
}
