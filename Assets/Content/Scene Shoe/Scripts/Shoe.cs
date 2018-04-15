using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Shoe : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerClickHandler {
  [Space()]
  public Transform graphic;
  public SmoothDampVector3 scale;
  public MeshRenderer[] primaryGraphic;
  public MeshRenderer[] secondaryGraphic;
  public MeshRenderer[] tertiaryGraphic;

  public void Update() {
    // var data = GameObject.FindWithTag("ShoeData").GetComponent<ShoeData>();
    var data = ShoeManager.instance.CurrentShoe();

    foreach (var item in primaryGraphic) {
      item.material.color = data.primary;
    }
    foreach (var item in secondaryGraphic) {
      item.material.color = data.secondary;
    }
    foreach (var item in tertiaryGraphic) {
      item.material.color = data.tertiary;
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
