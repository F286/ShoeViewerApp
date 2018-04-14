using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmoothDampScale : MonoBehaviour {
	public float smoothTime;
	public Vector3 target;
	public Vector3 velocity;

	public void Update () {
		transform.localScale = Vector3.SmoothDamp(transform.localScale, target, ref velocity, smoothTime);
	}
}
