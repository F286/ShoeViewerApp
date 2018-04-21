using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetMaskStencil : MonoBehaviour {
	public int stencil = 2;
	public Renderer[] targets;
	// public CanvasRenderer[] canvasTargets;
	// public Image image;

	public void Awake() {
		foreach (var item in targets) {
			item.material.SetInt("_StencilMask", stencil);
		}
		// foreach (var item in canvasTargets) {
		// 	item.GetMaterial().SetInt("_StencilMask", stencil);
		// }
		// if (image) {
		// 	print(stencil);
		// 	image.material.SetInt("_StencilMask", stencil);
		// }
	}

	public void Reset() {
		targets = GetComponentsInChildren<Renderer>();
		// canvasTargets = GetComponentsInChildren<CanvasRenderer>();
	}
}
