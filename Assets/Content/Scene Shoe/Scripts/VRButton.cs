using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class VRButton : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerClickHandler {

	public Transform graphic;
	public SmoothDampVector3 move;
	public Transform moveStart;
	public Transform moveEnd;

	public void LateUpdate() {
		graphic.localPosition = move.current;
	}
  public void OnPointerEnter(PointerEventData eventData) {
		move.target = moveEnd.localPosition;
  }
  public void OnPointerExit(PointerEventData eventData) {
		move.target = moveStart.localPosition;
  }
  public void OnPointerClick(PointerEventData eventData) {
  }
}
