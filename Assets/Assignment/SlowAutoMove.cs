using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlowAutoMove : MonoBehaviour {
    public enum Direction { Right, Left, Up, Down };
    public Direction direction = Direction.Right;
    public float speed = 0.2f;
    public bool isBounce = true;
    Vector3 direct = Vector3.right;

    // Use this for initialization
    void Start () {
        if (direction == Direction.Left)
        {
            direct = Vector3.left;
        }
        else if (direction == Direction.Down)
        {
            direct = Vector3.down;
        }
        else if (direction == Direction.Up)
        {
            direct = Vector3.up;
        }
    }
	
	// Update is called once per frame
	void Update () {
        transform.Translate(speed * direct);
        if (isBounce)
            CameraClamp();
    }


    public void CameraClamp()
    {
        Vector3 transVector = Camera.main.WorldToViewportPoint(transform.position);
        if (transVector.x < 0 || transVector.x > 1)
        {
            direct.x *= -1;
        }
        if (transVector.y < 0 || transVector.y > 1)
        {
            direct.y *= -1;
        }
    }
}
