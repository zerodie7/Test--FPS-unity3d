using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VidaPlayer : MonoBehaviour {

	public Image vidaActual;
	public Text  vidaTxt;

	private const int maxHealth = 100;
	private int currentHealth = 100;


	private void Start ()
	{
		UpdateVida ();
	}

	public void UpdateVida ()
	{
		float vida = currentHealth / maxHealth;
		vidaActual.rectTransform.localScale = new Vector3 (vida, 1, 1);
		vidaTxt.text = ((vida * 100).ToString () + '%');
	}

	public void TakeDamage (int damage)
	{
		currentHealth -= damage;
		if (currentHealth <= 0) 
		{
			currentHealth = 0;
			print ("Dead");
		}
		UpdateVida ();
	}

	public void HealDamage (int heal)
	{
		currentHealth += heal;
		if (currentHealth > maxHealth )
		{
			currentHealth = maxHealth;
		}
		UpdateVida ();
	}
}
