using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class AlphaBlending : MonoBehaviour
{
	public Image renderImage;
	public Text text;

/*

	void Awake()
	{
		SceneManager.sceneLoaded += OnSceneLoaded;
		StopAllCoroutines();
		StartUp();
	}


	private void OnDestroy()
	{
		SceneManager.sceneLoaded -= OnSceneLoaded;
	}
*/


	void OnSceneLoaded(Scene scene, LoadSceneMode mode)
	{
		StopAllCoroutines();
		StartUp();
	}

	void StartUp()
	{
		renderImage = GetComponent<Image>();
		if (renderImage)
		{
			Color newColor = renderImage.color;
			newColor.a = 0;
			renderImage.color = newColor;
		}
		text = GetComponent<Text>();
		if (text)
		{
			Color newColor = text.color;
			newColor.a = 0;
			text.color = newColor;
		}
	}


	IEnumerator FadeTo(float alphaValue, float time)
	{
		if (renderImage)
		{
			Color prev = renderImage.color;
			float alpha = renderImage.color.a;
			for (float t = 0.0f; t < 1.0f; t += Time.deltaTime / time)
			{
				Color newColor = new Color(prev.r, prev.g, prev.b, Mathf.Lerp(alpha, alphaValue, t));
				renderImage.color = newColor;
				yield return null;
			}
			Color neColor = renderImage.color;
			neColor.a = alphaValue;
			renderImage.color = neColor;
		}
		if (text)
		{
			Color prev = text.color;

			float alpha = text.color.a;
			for (float t = 0.0f; t < 1.0f; t += Time.deltaTime / time)
			{
				Color newColor = new Color(prev.r, prev.g, prev.b, Mathf.Lerp(alpha, alphaValue, t));
				text.color = newColor;
				yield return null;
			}
			Color neColor = text.color;
			neColor.a = alphaValue;
			text.color = neColor;
		}
		//yield return null;
	}

	public void ShowElement(float value, float time)
	{
		StopAllCoroutines();
		StartCoroutine(FadeTo(value, time));
	}

	public void HideElement(float time)
	{
		StopAllCoroutines();
		StartCoroutine(FadeTo(0.0f, time));
	}

	// Update is called once per frame
	void Update()
	{

	}
}
