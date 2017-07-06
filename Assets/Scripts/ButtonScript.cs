using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScript : MonoBehaviour {

	public GameRunner.Card current = (GameRunner.Card)0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void useCard () {
		GameRunner.GetComponent<GameRunner>().mat[((int)current) - 1] += 10;
		current = (GameRunner.Card)0;
		this.gameObject.SetActive(false);
	}
}
