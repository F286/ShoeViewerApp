using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmbientPosition : MonoBehaviour {
	public Vector3 direction;
	public float time = 3f;

	public void Update () {
		transform.localPosition = direction * Mathf.Sin(Time.time * Mathf.PI * 2f / time);
	}
}
