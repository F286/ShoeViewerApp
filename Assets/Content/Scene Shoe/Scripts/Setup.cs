using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Setup : MonoBehaviour {

  public void Awake() {
    Screen.orientation = ScreenOrientation.LandscapeLeft;
  }

  public static Setup instance;
  public void OnEnable() {
    instance = this;
  }
}
