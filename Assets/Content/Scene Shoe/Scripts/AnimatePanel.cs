using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatePanel : MonoBehaviour {
	public RectTransform target;
  public float smoothTime = 0.2f;

	[Space()]
	public Vector3 velocity;
	public float velocityAngular;
	public Vector2 sizeDeltaVelocity;

  // public RectTransform a;
  // public RectTransform b;
  // [Range(0, 1)]
  // public float t;

  public void Update () {
		var rectTransform = transform.GetComponent<RectTransform>();

		// Position
		rectTransform.position = Vector3.SmoothDamp(rectTransform.position, target.position, ref velocity, smoothTime, 1000);
		
		// Angle
		var angle = transform.rotation.eulerAngles;
		angle.y = Mathf.SmoothDampAngle(angle.y, target.transform.eulerAngles.y, ref velocityAngular, smoothTime, 1000);
		transform.rotation = Quaternion.Euler(angle);

		// Size
		rectTransform.sizeDelta = Vector2.SmoothDamp(rectTransform.sizeDelta, target.sizeDelta, ref sizeDeltaVelocity, smoothTime, 1000, Time.smoothDeltaTime);
		
		//Vector3.Lerp(a.position, b.position, t);
	}
}
