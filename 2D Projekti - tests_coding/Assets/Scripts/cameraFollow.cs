using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraFollow : MonoBehaviour {
    public Transform target;
    public float smoothTime = 0.2F;
    private Vector3 velocity = Vector3.zero;

	void Update () {
        Vector3 targetPosition = target.TransformPoint(new Vector3(7, 2, -10));
        transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, smoothTime);
	}
}
