using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmoothDampFloat : MonoBehaviour {
  public float smoothTime = 0.2f;
  [Range(0, 1)]
  public float current = 0;
  [Range(0, 1)]
  public float target = 0;
  [Range(0, 1)]
  public float velocity = 0;

  public void Update () {
    current = Mathf.SmoothDamp(current, target, ref velocity, smoothTime);
  }
}
