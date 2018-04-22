using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Shoe : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerClickHandler {
  public int index;
  [Space()]
  public MeshRenderer[] primaryGraphic;
  public MeshRenderer[] secondaryGraphic;
  public MeshRenderer[] tertiaryGraphic;

  public void LateUpdate() {
    var data = ShoeDataManager.instance.GetData(index);

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
  
  public void OnPointerEnter(PointerEventData eventData) {
  }
  public void OnPointerExit(PointerEventData eventData) {
  }
  public void OnPointerClick(PointerEventData eventData) {
  }

}
