using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class QuickTip : MonoBehaviour {

	private Image quickTipHolder;
	public Sprite quickTipImage;

	// Use this for initialization
	void Start()
	{
		quickTipHolder = GameObject.FindGameObjectWithTag("QuickTip").GetComponent<Image>();
		//QuickTipHolder.GetComponent<Image>() = QuickTipimage;
	}
	private void OnTriggerEnter(Collider other)
	{
		quickTipHolder.sprite = quickTipImage;
		quickTipHolder.GetComponent<AlphaBlending>().ShowElement(.65f,0.4f);
	}

	private void OnTriggerExit(Collider other)
	{
		quickTipHolder.GetComponent<AlphaBlending>().HideElement(1.0f);
	}
}
