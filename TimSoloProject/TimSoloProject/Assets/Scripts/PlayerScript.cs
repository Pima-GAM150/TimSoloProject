using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour {

    // Use this for initialization
    void Start () {

    }
	
	// Update is called once per frame
	void Update () {

        //The longer the button is held, the longer the distance you will go (to a point).
        if (Input.GetKey(KeyCode.Space))
        {
            print("Hello! This is what happens when you hold the spacebar.");
        }
	}
}
