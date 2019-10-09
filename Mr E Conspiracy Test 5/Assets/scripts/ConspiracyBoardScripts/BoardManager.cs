using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardManager : MonoBehaviour
{
	public GameObject Sous_Sticky;
	public GameObject Hostess_Sticky;
	public GameObject RedString;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		Check();
    }

	public void Check()
	{
		if(Sous_Sticky.activeSelf == true)
		{
			if (Hostess_Sticky.activeSelf == true)
			{
				RedString.SetActive(true);
			}
		}
	}
}
