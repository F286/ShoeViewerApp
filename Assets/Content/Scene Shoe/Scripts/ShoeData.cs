using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShoeData : MonoBehaviour {
	public string title;
	public string price;
  public Color primary = Color.white;
  public Color secondary = Color.white;
  public Color tertiary = Color.white;

	public void OnValidate() {
		if (Application.isPlaying) {
			return;
		}
		if (GetComponent<Shoe>()) {
			GetComponent<Shoe>().UpdateGraphics();
		}
	}
}
