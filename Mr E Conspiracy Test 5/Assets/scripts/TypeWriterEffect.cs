using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class TypeWriterEffect : MonoBehaviour
{

	public float delay = 0f;
	public string fullText;
	private string _currentText = "";

	void Start()
	{
		StartCoroutine(ShowText());
	}

	IEnumerator ShowText()
	{
		for (int i = 0; i < fullText.Length; i++)
		{
			_currentText = fullText.Substring(0, i);
			this.GetComponent<Text>().text = _currentText;
			yield return new WaitForSeconds(delay);
		}
	}
}
