using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CastingToObject : MonoBehaviour
{
	//'Static' causes it to appear in the inspector!
	public static string selectedObject;
	//internal version, only purpose is in this script
	public string internalObject;
	public RaycastHit theObject;
    void Update()
    {
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out theObject))
			{
			selectedObject = theObject.transform.gameObject.name;
			internalObject = theObject.transform.gameObject.name;
		}
    }
}
