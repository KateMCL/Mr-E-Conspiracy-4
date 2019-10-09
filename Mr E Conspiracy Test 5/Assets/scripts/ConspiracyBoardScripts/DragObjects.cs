using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragObjects : MonoBehaviour
{
	//public GameObject RoomCurrent;
	public GameObject Char_Comment_Current;

  private Vector3 mOffset;
  private float mZCoord;

    void OnMouseDown()
    {
        mZCoord = Camera.main.WorldToScreenPoint(gameObject.transform.position).z;

        //Store offset = gameobject world pos - mouse world pos
        mOffset = gameObject.transform.position - GetMouseWorldPos();
				//RoomCurrent.SetActive(false);
				Char_Comment_Current.SetActive(true);
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

	//void OnMouseUp()
	//{
	//	Char_Comment_Current.SetActive(false);
	//}
}


