using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CommentManager : MonoBehaviour
{
	public GameObject Char_Comment_MRE;
	public GameObject Clue_1_Mr_E;
	public GameObject Char_Comment_Sous;
	public GameObject Clue_2_Sous;
	public GameObject Char_Comment_Hostess;
	public GameObject Clue_3_Hostess;

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
		//REMOVE MR E COMMENT
		if (Char_Comment_MRE.activeSelf == true)
		{
			if (Clue_1_Mr_E.activeSelf == false)
			{
				Char_Comment_MRE.SetActive(false);
			}
		}
		// REMOVE SOUS COMMENT
		if (Char_Comment_Sous.activeSelf == true)
		{
			if (Clue_2_Sous.activeSelf == false)
			{
				Char_Comment_Sous.SetActive(false);
			}
		}
		// REMOVE HOSTESS COMMENT
		if (Char_Comment_Hostess.activeSelf == true)
		{
			if (Clue_3_Hostess.activeSelf == false)
			{
				Char_Comment_Hostess.SetActive(false);
			}
		}
	}


}
