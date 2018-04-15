using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmoothDampAngle : MonoBehaviour {
	public float smoothTime = 0.2f;
	public float current = 0;
	public float target = 0;
	public float velocity = 0;

	public void Update () {
		current = Mathf.SmoothDampAngle(current, target, ref velocity, smoothTime);
	}
}
