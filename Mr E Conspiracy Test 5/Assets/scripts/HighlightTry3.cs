using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HighlightTry3 : MonoBehaviour
{
	Material m_Material;
    // Start is called before the first frame update
    void Start()
    {
		m_Material = GetComponent<Renderer>().material;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

	void OnMouseEnter()
	{
		m_Material.color = Color.yellow;
	}

	void OnMouseExit()
	{
		m_Material.color = Color.white;
	}

}
