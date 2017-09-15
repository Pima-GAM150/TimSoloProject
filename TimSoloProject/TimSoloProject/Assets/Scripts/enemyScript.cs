using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyScript : MonoBehaviour {

    public Rigidbody2D EnemyCharacter;
    public float horizontalMovement;
    public bool enemyIsAlive;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (EnemyCharacter != null)
        {
            EnemyCharacter.transform.Translate(new Vector2(-1, 0) * 4 * Time.deltaTime);
        }
	}
}
