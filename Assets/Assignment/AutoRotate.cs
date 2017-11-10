using UnityEngine;
using System.Collections;

public class AutoRotate : MonoBehaviour {
	public enum Direction {Right, Left};
	public Direction direction = Direction.Right;
	public float speed = 1f;
	Vector3 direct = Vector3.back;

	// Use this for initialization
	void Start () {
		if (direction == Direction.Left) {
			direct = Vector3.forward;
		}
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate (direct * speed);
	}
}
