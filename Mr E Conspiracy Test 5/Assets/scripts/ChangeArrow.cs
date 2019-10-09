using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeArrow : MonoBehaviour
{
	public GameObject ArrowCurrent;
	public GameObject ArrowNext;


	private Vector3 mOffset;
	private float mZCoord;

	void OnMouseDown()
	{
		mZCoord = Camera.main.WorldToScreenPoint(gameObject.transform.position).z;

		//Store offset = gameobject world pos - mouse world pos
		mOffset = gameObject.transform.position - GetMouseWorldPos();
		ArrowCurrent.SetActive(false);
		ArrowNext.SetActive(true);
	}

	private Vector3 GetMouseWorldPos()

	{
		//pixel coordinates (x,y)
		Vector3 mousePoint = Input.mousePosition;

		mousePoint.z = mZCoord;

		return Camera.main.ScreenToWorldPoint(mousePoint);
	}

	void OnMouseDrag()

	{
		transform.position = GetMouseWorldPos() + mOffset;
	}
}
