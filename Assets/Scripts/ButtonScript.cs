using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonScript : MonoBehaviour {

	public GameRunner.Card current = (GameRunner.Card)0;
	private Button button;
	public Material mat;

	// Use this for initialization
	void Start () {
		button = GetComponent<Button>();
		mat = Resources.Load("Materials/wood") as Material;
		print("Load");
		button.image.material = mat;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void useCard () {
		GameObject gameRunner = GameObject.Find("GameRunner");
		gameRunner.GetComponent<GameRunner>().mat[((int)current) - 1] += 10;
		current = (GameRunner.Card)0;
		this.gameObject.SetActive(false);
	}
}
