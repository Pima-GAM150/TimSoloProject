using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour {

    public Rigidbody2D PlayerCharacter;
    public float jumpForce;
    public float horizontalMovement;
    public float verticalVelocity;
    public int jumpCount = 0;
    public bool isGrounded;

    // Use this for initialization
    void Start () {

    }
	
	// Update is called once per frame
	void Update () {

        verticalVelocity = PlayerCharacter.velocity.y;

        if (verticalVelocity == 0)
        {
            jumpCount = 0;
        }

        //Causes the player to jump when Spacebar is pressed and prevents multi-jumping.
        if (Input.GetKeyDown(KeyCode.Space) && jumpCount < 1)
        {
            PlayerCharacter.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);
            jumpCount += 1;
        }

        //Allows for horizontal movement
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.LeftArrow))
        {
            horizontalMovement = Input.GetAxis("Horizontal");
            PlayerCharacter.transform.Translate(new Vector2(horizontalMovement, 0) * 6 * Time.deltaTime);
        }

    }
}
