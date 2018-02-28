using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour {

	public Text timerText;
	private float starTime;
	private bool finnished = false;

	void Start () {
		starTime = Time.time;
	}
	
	void Update () {
		if (finnished)
			return;
			
		float t = Time.time - starTime;

		string minutes = ((int)t / 60).ToString();
		string seconds = (t % 60).ToString("f2"); //Dos decimales en el flotante

		timerText.text = minutes + ":" + seconds;
	}

	public void Finnish()
	{
		finnished = true;
		timerText.color = Color.blue;
	}

}
