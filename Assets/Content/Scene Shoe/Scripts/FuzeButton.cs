using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class FuzeButton : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler {
	public bool isEnter;
	public float enterTime;

	const float triggerTime = 1f;
	
  public void OnPointerEnter(PointerEventData eventData) {
		isEnter = true;
		enterTime = Time.time;
  }

  public void OnPointerExit(PointerEventData eventData) {
		isEnter = false;
  }

	public void Update() {
		if (isEnter) {
			if (Time.time - enterTime > triggerTime) {
				isEnter = false;
				GetComponent<Button>().onClick.Invoke();
			}
		}
	}

}
