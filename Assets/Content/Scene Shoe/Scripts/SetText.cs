using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetText : MonoBehaviour {
  public Type type;
  public int offset;

  public void LateUpdate () {
    var data = ShoeDataManager.instance.GetData(offset);

    switch (type) {
      case Type.Title:
        GetComponent<Text>().text = data.title;
        break;
      case Type.Price:
        GetComponent<Text>().text = data.price;
        break;
    }
  }

  public enum Type {
    Title,
    Price
  }
}
