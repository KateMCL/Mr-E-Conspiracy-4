using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{
	public GameObject key;
	public GameObject wallet;
	public GameObject phone;
	public GameObject door_opener;
	public GameObject door_unopened;
	//public GameObject door_closed;

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
		if (key.activeSelf == false & wallet.activeSelf == false & phone.activeSelf == false)
		{
			door_opener.SetActive(true);
			door_unopened.SetActive(false);
			//door_closed.SetActive(false);
		}
	}

}
