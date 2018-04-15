﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShoeManager : MonoBehaviour {

	public int current = 0;

	public ShoeData CurrentShoe() {
		if (current < 0) {
			current = current + Mathf.Abs(current) - Mathf.Abs(current % transform.childCount) + transform.childCount;
		}
		return transform.GetChild(current % transform.childCount).GetComponent<ShoeData>();
	}

	public void Next() {
		current += 1;
	}
	public void Previous() {
		current -= 1;
	}

	public static ShoeManager instance;
	public void OnEnable() {
		instance = this;
	}
}
