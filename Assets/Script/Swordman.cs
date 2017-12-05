﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Swordman : Unit {

	// Update is called once per frame
	void Update () {
		
	}

	public override void isDead(){
		if(health <= 0 ){
			print ("Destroying " + this.gameObject.name);
			if (!this.isEnemy) {
				Destroy (this.gameObject);
			} else {
				Destroy (this.gameObject);
			}
		}
	}

	public override void loseHealth(int ATK){
		health -= ATK;
	}
		
	/*public override void betray(){
		var rand = UnityEngine.Random.Range(0, 10);
		if (!hasBetrayed && rand == 0) {
			//TODO
			//change sprite image
			//remove this unit from the Unit list it is currently in 
			//add to the opponent side unit list 

		}
	}*/
}
