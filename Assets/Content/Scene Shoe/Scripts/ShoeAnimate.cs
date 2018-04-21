using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShoeAnimate : MonoBehaviour {
	public float smooth = 0.1f;
	public Vector3[] slideOffset = new Vector3[1] { new Vector3(700, 20, 0) };
	public Transform[] shoes;
	public CanvasGroup[] titles;
	public ShoeDataManager shoeData;
	public float t = 1f;
	public float tVelocity = 0f;

	public void Next() {
		Setup.instance.StopAllCoroutines();
		Setup.instance.StartCoroutine(AnimateTo(1));
	}
	public void Previous() {
		Setup.instance.StopAllCoroutines();
		Setup.instance.StartCoroutine(AnimateTo(-1));
	}
	public IEnumerator AnimateTo(int offset) {

		while(t > 0.005f) {
			t = Mathf.SmoothDamp(t, 0, ref tVelocity, smooth, 10000);

			Animate(t, new Vector3(-offset, 1, 1), Vector3.zero);
			yield return new WaitForEndOfFrame();
		}

		shoeData.AddToOffset(offset);
		
		while(t < 0.999f) {
			t = Mathf.SmoothDamp(t, 1, ref tVelocity, smooth, 10000);

			Animate(t, new Vector3(offset, 1, 1), Vector3.zero);
			yield return new WaitForEndOfFrame();
		}
		Animate(1, Vector3.zero, Vector3.zero);
	}

	public void Animate(float t, Vector3 zero, Vector3 one) {
		var index = 0;
		foreach (var item in shoes) {
			item.localPosition = Vector3.Lerp(Vector3.Scale(zero, slideOffset[index]), 
																				Vector3.Scale(one, slideOffset[index]), t);
			index += 1;
		}
		foreach (var item in titles) {
			item.alpha = t;
		}
	}

}
