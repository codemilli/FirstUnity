using UnityEngine;
using System.Collections;

public class MoveObject : MonoBehaviour {
	public float speed = 1f;
	Vector3 input;
	void Start() {
		input = Vector3.zero;
	}
	void Update() {
		input.x = Input.GetAxis ("Horizontal");
		input.y = Input.GetAxis ("Vertical");
		transform.Translate (input * speed * Time.deltaTime);
	}
}
