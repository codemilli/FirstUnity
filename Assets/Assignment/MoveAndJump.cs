using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveAndJump : MonoBehaviour {

    public bool isJumped = false;

    Vector2 speed = new Vector2(10, 20);
    Vector3 input;

	// Use this for initialization
	void Start () {
        input = Vector3.zero;
	}
	
	// Update is called once per frame
	void Update () {
        input.x = Input.GetAxis("Horizontal");
        transform.Translate(input * speed.x * Time.deltaTime);

        if (Input.GetKeyDown (KeyCode.Space))
        {
            if (!isJumped)
            { 
                transform.Translate(new Vector3(0, 10f, 0) * speed.y * Time.deltaTime);
                
                if (transform.position.y > 150)
                {
                    isJumped = true;
                }
            }
        }

        if (isJumped && transform.position.y <= 1)
        {
            isJumped = false;
        }
    }
}
