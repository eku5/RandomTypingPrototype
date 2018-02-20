using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomInputTest : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {

	//Check if the KeyCode is a letter
		for (int i = 0;i < 26;i++){
			
			if (Input.GetKeyUp(KeyCode.A + i))
			print("gibberish");
		

	}
}
