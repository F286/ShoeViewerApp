﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Shoe : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerClickHandler {
  public Transform graphic;
  public SmoothDampVector3 scale;
	
  public void OnPointerClick(PointerEventData eventData) {
		print("click");
  }
  public void OnPointerEnter(PointerEventData eventData) {
		print("enter");
    scale.target = Vector3.one * 1.1f;
  }
  public void OnPointerExit(PointerEventData eventData) {
		print("exit");
    scale.target = Vector3.one * 1.0f;
  }

  public void LateUpdate() {
    graphic.localScale = scale.current;
  }
}
