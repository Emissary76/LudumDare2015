﻿using UnityEngine;
using System.Collections;

public class FlagBasketCollision : MonoBehaviour {

	public BalloonData data;
	

	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other){
		//Debug.LogError("flagged basket");
		data.objectHittingBasket = other;
	}
}
