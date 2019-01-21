using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/* 1/10/2019 CJA
 * Allows camera to follow player smoothly
 * Version 1
 */
public class CameraFollow : MonoBehaviour {
	public Transform target;
	public float smoothSpeed = 0.125f;
	public Vector3 offset;

	void FixedUpdate(){
		Vector3 desiredPosition = target.position + offset;
		Vector3 smoothedPosition = Vector3.Lerp (transform.position, desiredPosition, smoothSpeed);
		transform.position = smoothedPosition;

	}
}
