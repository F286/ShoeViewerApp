using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineArc : MonoBehaviour {
	public LineRenderer line;
	public float radius = 1;
	public float startAngle = -90;
	public float endAngle = 90;
	public int segments = 16;

	public void OnValidate() {
		var arcPoints = new List<Vector3>();
		var angle = startAngle;
		var arcLength = endAngle - startAngle;
		for (int i = 0; i <= segments; i++)
		{
				var x = Mathf.Sin(Mathf.Deg2Rad * angle) * radius;
				var y = Mathf.Cos(Mathf.Deg2Rad * angle) * radius;

				arcPoints.Add(new Vector2(x,y));

				angle += (arcLength / segments);
		}
		line.positionCount = arcPoints.Count;
		line.SetPositions(arcPoints.ToArray());
	}
}
