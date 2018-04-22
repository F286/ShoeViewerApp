using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmbientRotation : MonoBehaviour {
  public Vector3 velocity = new Vector3(20, 0, 0);

  public void Update () {
    transform.localRotation *= Quaternion.Euler(velocity * Time.smoothDeltaTime);
  }
}
