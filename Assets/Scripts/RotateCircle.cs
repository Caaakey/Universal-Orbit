using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCircle : MonoBehaviour {

    public float speed = .5f;
    public Transform target = null;
    public Vector3 point = Vector3.zero;
    public Vector3 axis = Vector3.zero;

	void Update ()
    {
        if (target != null)
            transform.RotateAround(target.localPosition, axis, speed);
        else if (point != Vector3.zero)
            transform.RotateAround(point, axis, speed);
        else
            transform.Rotate(axis, speed);
	}
}
