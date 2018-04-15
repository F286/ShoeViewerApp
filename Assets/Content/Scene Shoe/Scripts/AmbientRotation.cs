using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmbientRotation : MonoBehaviour {
	public Vector3 velocity;

	public void Update () {
		transform.localRotation *= Quaternion.Euler(velocity * Time.smoothDeltaTime);
	}
}
