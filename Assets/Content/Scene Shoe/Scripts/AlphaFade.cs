using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlphaFade : MonoBehaviour {
  public CanvasGroup group;
  public SmoothDampFloat smooth;

  public void FadeIn() {
    smooth.target = 1;
  }
  public void FadeOut() {
    smooth.target = 0;
  }

  public void Update () {
    group.alpha = smooth.current;

    var isShow = smooth.current > 0.001f;
    if (isShow != group.gameObject.activeSelf) {
      group.gameObject.SetActive(isShow);
    }
    if (isShow) {
      group.BroadcastMessage("Fade", smooth.current);
    }
  }
}
