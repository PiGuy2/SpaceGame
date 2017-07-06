using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameRunner : MonoBehaviour {

	Card[] deck = new Card[50];
	int drawNum = 0;

	public int[] mat = new int[5];
	/*
	public int food = 0;
	public int wood = 0;
	public int metal = 0;
	public int money = 0;
	public int fuel = 0;
	*/

	// Use this for initialization
	void Start () {
		shuffleDeck();
		// -----
		int[] count = new int[6];
		for (int i = 0; i < 100; i++) {
			count[(int)draw()]++;
			// print(deck[i]);
		}
		for (int i = 0; i < 6; i++) {
			print("Count 2 " + i.ToString() + ": " + count[i].ToString());
		}
		draw();
		// -----
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void shuffleDeck () {
		int[] sel = new int[5];
		for (int i = 0; i < 50;) {
			int n = Random.Range(1, 6);
			if (sel[n - 1] < 10) {
				deck[i] = (Card)n;
				sel[n - 1] += 1;
				i++;
			}
		}
		int[] count = new int[6];
		for (int i = 0; i < 50; i++) {
			count[(int)deck[i]]++;
			// print(deck[i]);
		}
		for (int i = 0; i < 6; i++) {
			print("Count " + i.ToString() + ": " + count[i].ToString());
		}
		drawNum = 0;
	}

	Card draw () {
		if (drawNum >= 50) {
			shuffleDeck();
			// print("shuffle");
		}
		drawNum++;
		return deck[drawNum - 1];
	}

	public enum Card : int {
		food = 1,
		wood = 2,
		metal = 3,
		money = 4,
		fuel = 5}

	;
}