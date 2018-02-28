using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class StartMonster : MonoBehaviour {

	public NavMeshAgent miMesh;

	void Start () {
		miMesh = GetComponent<NavMeshAgent> ();
	}
	
	void Update () {

		if (Score.scoreValue == 30) {
			miMesh.enabled = true;
		}

	}
}
