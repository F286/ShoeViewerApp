using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmoothDampVector3 : MonoBehaviour {
	public float smoothTime = 0.2f;
	public Vector3 current = Vector3.zero;
	public Vector3 target = Vector3.zero;
	public Vector3 velocity = Vector3.zero;

	public void Update () {
		current = Vector3.SmoothDamp(current, target, ref velocity, smoothTime);
	}
}
