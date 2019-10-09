using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeINCounter : MonoBehaviour
{
	public GameObject FaderIN;
	public GameObject Button;
	// Start is called before the first frame update
    void Start()
    {
		StartCoroutine("FadeIN");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

	IEnumerator FadeIN()
	{
		yield return new WaitForSecondsRealtime(7);
		{
			FaderIN.SetActive(false);
			Button.SetActive(true);
		}
	}
}
