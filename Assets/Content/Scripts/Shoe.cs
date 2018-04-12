using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Shoe : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerClickHandler {
	
  public void OnPointerClick(PointerEventData eventData) {
		print("click");
  }

  public void OnPointerEnter(PointerEventData eventData) {
		print("enter");
		
  }

  public void OnPointerExit(PointerEventData eventData) {
		print("exit");
		
  }
}
