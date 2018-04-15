using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShoeData : MonoBehaviour {
	public string price;
  public Color primary = Color.white;
  public Color secondary = Color.white;
  public Color tertiary = Color.white;

	public string title {
		get {
			return name;
		}
	}
}
