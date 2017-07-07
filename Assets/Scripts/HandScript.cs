using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandScript : MonoBehaviour {

	public GameRunner.Card[] hand = new GameRunner.Card[7];
	public int nextEmpty = 0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void shift () {
		GameRunner.Card[] newHand = new GameRunner.Card[7];
		int n = 0;
		for (int i = 0; i < 7; i++) {
			if ((int)hand[i] != 0) {
				newHand[n] = hand[i];
				n++;
			}
		}
		hand = newHand;
		nextEmpty = n;
	}
}
