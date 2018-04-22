using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmoothDampColor : MonoBehaviour {
  public float smoothTime = 0.06f;
  public Vector3 currentRaw = Vector3.one;
  public Color target = Color.white;
  public Vector3 velocity = Vector3.zero;

  public Color current {
    get {
      return new Color(currentRaw.x, currentRaw.y, currentRaw.z);
    }
  }

  public void Update () {
    var targetRaw = new Vector3(target.r, target.g, target.b);
    currentRaw = Vector3.SmoothDamp(currentRaw, targetRaw, ref velocity, smoothTime);
  }
}
