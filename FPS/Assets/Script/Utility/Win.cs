using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Win : MonoBehaviour {

	public Text ganador;

	void Start () {
		ganador = GetComponent<Text> ();
	}

	void Update () {

		if (Score.scoreValue == 100) {
			ganador.enabled = true;
		}

	}
}
