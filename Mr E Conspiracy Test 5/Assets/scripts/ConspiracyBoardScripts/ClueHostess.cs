﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClueHostess : MonoBehaviour
{
	// HOSTESS CLUE STICKY SCRIPT

	public GameObject stickied_clue;
	public GameObject deactivated_clue;

	// Start is called before the first frame update
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{

	}
	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Clue_Hostess")
		{
			Debug.Log("hello");
			stickied_clue.SetActive(true);
			deactivated_clue.SetActive(false);
		}

	}

}
