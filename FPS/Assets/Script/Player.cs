using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {


	public Transform playerSpawnPoints;
	public bool reSpawn = false;

	private Transform[] spawnPoints;
	private bool lastToggle = false;

	void Start () 
	{
		spawnPoints = playerSpawnPoints.GetComponentsInChildren<Transform> ();
	}

	void Update ()
	{
		if (lastToggle != reSpawn) {
			Respawn ();
			reSpawn = false;
		} else {
			lastToggle = reSpawn;
		}

		if (Input.GetKey ("escape")) {
			Application.Quit ();
			print ("salir");
		}
	}

	private void Respawn() 
	{
		int i = Random.Range (1, spawnPoints.Length);
		transform.position = spawnPoints [i].transform.position;
	}


}
