using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShoeAnimate : MonoBehaviour {
	// public SmoothDampFloat offset;
	public Transform[] shoes;
	// public Transform[] targets;

	public void Next() {
		GameObject.FindWithTag("Setup").GetComponent<Setup>().StartCoroutine(AnimateTo(1));
	}
	public void Previous() {
		GameObject.FindWithTag("Setup").GetComponent<Setup>().StartCoroutine(AnimateTo(-1));
	}
	public IEnumerator AnimateTo(int offset) {
		var t = 0f;

		while(t < 1) {
			t += Time.smoothDeltaTime;

			foreach (var item in shoes) {
				item.localScale = Vector3.Lerp(Vector3.one, Vector3.zero, t);
			}
			yield return new WaitForEndOfFrame();
		}
		
		t = 0f;
		while(t < 1) {
			t += Time.smoothDeltaTime;

			foreach (var item in shoes) {
				item.localScale = Vector3.Lerp(Vector3.zero, Vector3.one, t);
			}
			yield return new WaitForEndOfFrame();
		}
	}
}
