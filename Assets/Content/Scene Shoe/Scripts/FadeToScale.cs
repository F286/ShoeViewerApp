using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeToScale : MonoBehaviour {
  public void Fade(float fade) {
    transform.localScale = new Vector3(fade, fade, fade);
  }
}
