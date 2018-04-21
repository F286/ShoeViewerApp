using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShoeAnimate : MonoBehaviour {
	public float smooth = 0.1f;
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

			Animate(t, new Vector3(-250 * offset, 20, 0), Vector3.zero);
			yield return new WaitForEndOfFrame();
		}

		shoeData.AddToOffset(offset);
		
		while(t < 0.999f) {
			t = Mathf.SmoothDamp(t, 1, ref tVelocity, smooth, 10000);

			Animate(t, new Vector3(250 * offset, 20, 0), Vector3.zero);
			yield return new WaitForEndOfFrame();
		}
		Animate(1, Vector3.zero, Vector3.zero);
	}

	public void Animate(float t, Vector3 zero, Vector3 one) {
		foreach (var item in shoes) {
			item.localScale = Vector3.Lerp(Vector3.zero, Vector3.one, t);
			item.localPosition = Vector3.Lerp(zero, one, t);
		}
		foreach (var item in titles) {
			item.alpha = t;
		}
	}

}
