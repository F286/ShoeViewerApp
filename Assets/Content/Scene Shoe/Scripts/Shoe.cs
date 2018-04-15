using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Shoe : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerClickHandler {
  public Color primary = Color.white;
  public Color secondary = Color.white;
  public Color tertiary = Color.white;
  [Space()]
  public Transform graphic;
  public SmoothDampVector3 scale;
  public MeshRenderer[] primaryGraphic;
  public MeshRenderer[] secondaryGraphic;
  public MeshRenderer[] tertiaryGraphic;

  public void Update() {
    foreach (var item in primaryGraphic) {
      item.material.color = primary;
    }
    foreach (var item in secondaryGraphic) {
      item.material.color = secondary;
    }
    foreach (var item in tertiaryGraphic) {
      item.material.color = tertiary;
    }
  }
  
  public void LateUpdate() {
    graphic.localScale = scale.current;
  }
	
  public void OnPointerEnter(PointerEventData eventData) {
		print("enter");
    scale.target = Vector3.one * 1.05f;
  }
  public void OnPointerExit(PointerEventData eventData) {
		print("exit");
    scale.target = Vector3.one * 1.0f;
  }
  public void OnPointerClick(PointerEventData eventData) {
		print("click");
  }

}
