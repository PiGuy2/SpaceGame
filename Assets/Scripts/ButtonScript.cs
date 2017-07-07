using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonScript : MonoBehaviour {

	public int num = 0;
	public GameRunner.Card current = (GameRunner.Card)0;
	private Button button;
	public Material mat;

	GameObject scriptObject;
	GameRunner gameRunner;
	GameObject handObject;
	HandScript handRunner;

	// Use this for initialization
	void Start () {
		scriptObject = GameObject.Find("ScriptObject");
		gameRunner = scriptObject.GetComponent<GameRunner>();
		//
		handObject = GameObject.Find("HandRunner");
		handRunner = handObject.GetComponent<HandScript>();
	}
	
	// Update is called once per frame
	void Update () {
		if (handRunner.hand[num] != current) {
			setCard(handRunner.hand[num]);
		}
	}

	public void useCard () {
		gameRunner.mat[((int)current) - 1] += 10;
		handRunner.hand[num] = GameRunner.Card.empty;
		current = (GameRunner.Card)0;
		handRunner.shift();
		setActive(false);
	}

	public void setCard (GameRunner.Card card) {
		if ((int)card != 0) {
			current = card;
			setImage(gameRunner.getCardName((int)card));
			setActive(true);
		} else {
			current = card;
			setActive(false);
		}
	}

	void setImage (string name) {
		button = GetComponent<Button>();
		mat = Resources.Load("Materials/" + name) as Material;
		button.image.material = mat;
	}

	void setActive (bool active) {
		this.gameObject.GetComponent<Image>().enabled = active;
	}
}
