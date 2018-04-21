using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShoeAnimate : MonoBehaviour {
	public Transform[] shoes;
	public CanvasGroup[] titles;
	public ShoeDataManager shoeData;
	public float smooth = 0.1f;
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

		while(t > 0.01f) {
			t = Mathf.SmoothDamp(t, 0, ref tVelocity, smooth, 10000);

			Animate(t);
			yield return new WaitForEndOfFrame();
		}

		shoeData.AddToOffset(offset);
		
		while(t < 0.999f) {
			t = Mathf.SmoothDamp(t, 1, ref tVelocity, smooth, 10000);

			Animate(t);
			yield return new WaitForEndOfFrame();
		}
	}

	public void Animate(float t) {
		foreach (var item in shoes) {
			item.localScale = Vector3.Lerp(Vector3.zero, Vector3.one, t);
		}
		foreach (var item in titles) {
			item.alpha = t;
		}
	}
	
}
