using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Doughnut : MonoBehaviour {
	public float spacing = 24;
	public SmoothDampAngle angle;
	public int index;
	public TextMesh title;
	public TextMesh price;

	public void LateUpdate () {
		transform.localRotation = Quaternion.Euler(0, -angle.current, 0);
		var data = transform.GetChild(index).GetComponentInChildren<ShoeData>();
		title.text = data.title;
		price.text = data.price;
	}
	public void Next() {
		index = (index - 1 + transform.childCount) % transform.childCount;
		angle.target = index * spacing;
	}
	public void Previous() {
		index = (index + 1) % transform.childCount;
		angle.target = index * spacing;
	}
}
