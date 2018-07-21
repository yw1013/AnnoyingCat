// ﻿using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;
//
// public class DogWanderScript : MonoBehaviour {
//
// 	// Use this for initialization
// 	void Start () {
// 		rayDist = GetComponent<CharacterController>().radius * 2; //set the rayDist for this animal | the rayDist is equal to twice the radius of the animal's CharacterController
// 		waitTime = 0; //make sure waitTime starts at 0
// 		timer = 0; //make sure timer starts at 0
//
// 		//get characterController
// 		controller = transform.GetComponent<CharacterController>();
//
// 		//get animal's starting position
// 		startPos = transform.position;
//
// 		//face a random direction at start
// 		var randomRot = Random.Range(0, 360); //get a random rotation
// 		transform.rotation = Quaternion.Euler(0, randomRot, 0); //face direction
//
// 		//randomly decide wheather to stand idle, or to walk, at start
// 		var randomIdle = Random.Range(1, 3);
// 		if(randomIdle == 1) {
// 			idle = false;
// 		}
// 		else {
// 			idle = true;
// 		}
//
// 		//Walk or stand Idle
// 		NewDecision();
// 	}
//
//
// 	// Update is called once per frame
// 	void Update () {
//
// 	}
//
//
//
// void FixedUpdate() {
// 	//**INCREASE TIMER**
// 	timer += 1 * Time.deltaTime; //timer increases by 1 every second
//
// 	//**APPLY GRAVITY**
// 	if(moveDirection.y > gravity * -1) {
// 		moveDirection.y -= gravity * Time.deltaTime;
// 	}
// 	controller.Move(moveDirection * Time.deltaTime);
// }
// void Update() {
// 	//**FORWARD DIRECTION**
// 	//get the direction the animal is facing
// 	forward = transform.TransformDirection(Vector3.forward);
//
// 	//**DISTANCE BETWEEN**
// 	//calculate distanceBetween animal's current position, and its starting position
// 	distanceBetween = Vector3.Distance(transform.position, startPos); //can put this line in FixedUpdate() instead, but it won't be as accurrate in keeping the animal within maxDistance bounds
//
// 	//**IDLE**
// 	if(idle == true) {
// 		//while timer is less than idle time
// 		if(timer < waitTime) {
// 			//if idle animation is over, play another one
// 			if(!animal.GetComponent<Animation>().isPlaying) {
// 				//Call RandomIdle() function, to detertime next idle animation
// 				RandomIdle();
// 			}
// 		}
// 		else {
// 			//when idle time is up
// 			//if idle animation is over, play walk
// 			if(!animal.GetComponent<Animation>().isPlaying) {
// 				NewDecision();
// 			}
// 		}
// 	}
// 	//**WALK**
// 	//while timer is less than walking time, keep walking
// 	else {
// 		if(timer < waitTime) {
// 			//Face new direction, over time
// 			//transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.Euler(0, newDirection, 0), Time.deltaTime * 25);
//
// 			//make sure animal does not walk too far out of maxDistance
// 			if(distanceBetween < maxDistance || returningHome == true) { //if within maxDistance, or returingHome
// 				//get our raycast point
// 				raycastPoint = new Vector3(transform.position.x, GetComponent<CharacterController>().height / 2, transform.position.z);
// 				//check if an obstacle is in our way
// 				if(Physics.Raycast(raycastPoint, transform.forward, out hit, rayDist)) {
// 					//something is in our way, let's stand idle, and move a new direction next time
// 					timer = waitTime;
// 				}
// 				else {
// 					controller.SimpleMove(transform.forward * speed); //move forward, times speed
// 				}
// 			}
// 			else {
// 				//if animal exceeds maxDistance, walking time is ended. Animal will stand idle for a while, then head towards startPos when it begins walking again
// 				timer = waitTime;
// 			}
// 		}
// 		else {
// 			//when walking time is up, play idle
// 			NewDecision();
// 		}
// 	}
// }
// }
