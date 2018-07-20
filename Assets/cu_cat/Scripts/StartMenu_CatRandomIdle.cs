using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartMenu_CatRandomIdle : MonoBehaviour {

    Animator anim;
    float randomNumber;

	// Use this for initialization
	void Start () {
        anim = this.GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        //Debug.Log(randomNumber);
        randomNumber = Random.Range(0f, 100f);
         
        if (0f < randomNumber && randomNumber < 8f) {
            //B_wash
            anim.SetInteger("motion", 10);
        } 

        else if (20f < randomNumber && randomNumber < 28f) {
            //B_wash_b
            anim.SetInteger("motion", 20);
        } 

        else if (70f < randomNumber && randomNumber < 75f) {
            //B_play
            anim.SetInteger("motion", 30);
        } 

        else if (90f < randomNumber && randomNumber < 98f) {
            //B_picks
            anim.SetInteger("motion", 40);
        } 

        else {
            anim.SetInteger("motion", 50);
        }

	}
}
