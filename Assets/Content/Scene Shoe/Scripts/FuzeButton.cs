using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class FuzeButton : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler {
	public Image image;
	public bool canRepeat;
	[Space()]
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
				if (canRepeat) {
					enterTime = Time.time;
				}
				else {
					isEnter = false;
				}
				GetComponent<Button>().onClick.Invoke();
			}
		}
		if (image) {
			image.fillAmount = isEnter ? (Time.time - enterTime) / triggerTime : 0;
		}
	}

}
