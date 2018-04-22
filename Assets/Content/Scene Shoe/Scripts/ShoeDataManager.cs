using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShoeDataManager : MonoBehaviour {
  public Data[] data;
  public int offset;

  public Data GetData(int index) {
    var current = index + offset;
    current += (Mathf.Abs(current) / data.Length) * data.Length + data.Length;
    return data[current % data.Length];
  }
  public void AddToOffset(int add) {
    offset += add;
  }

  public static ShoeDataManager instance;
  public void OnEnable() {
    instance = this;
  }

  [System.Serializable]
  public class Data {
    public string title;
    public string price;
    public Color primary = Color.white;
    public Color secondary = Color.white;
    public Color tertiary = Color.white;
  }
}
