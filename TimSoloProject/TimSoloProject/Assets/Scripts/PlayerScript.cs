using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour {

    public Rigidbody2D PlayerCharacter;
    public float jumpForce;
    public float horizontalMovement;

    // Use this for initialization
    void Start () {

    }
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            PlayerCharacter.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);
        }

        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.LeftArrow))
        {
            horizontalMovement = Input.GetAxis("Horizontal");
            PlayerCharacter.transform.Translate(new Vector2(horizontalMovement, 0) * 3 * Time.deltaTime);
        }

	}
}
