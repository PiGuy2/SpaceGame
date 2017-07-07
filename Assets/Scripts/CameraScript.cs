using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class CameraScript : NetworkBehaviour {

	// Use this for initialization
	void Start () {
		transform.position = new Vector3(0, 3, 0);
		transform.eulerAngles = new Vector3(90, 0, 0);
	}
	
	// Update is called once per frame
	void Update () {
		if (!isLocalPlayer) {
			return;
		}

		var x = Input.GetAxis("Horizontal") * 0.1f;
		var z = Input.GetAxis("Vertical") * 0.1f;

		transform.Translate(x, 0, z, Space.World);
	}
}
