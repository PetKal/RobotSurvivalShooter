using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerHealth : MonoBehaviour {

	public int startingHealth = 100;
	public int currentHealth;
	public Slider healthSlider;
	public Image damageImage;
	public float flashSpeed = 5f;
	public Color flashColour = new Color(1f, 0f, 0f, 0.1f);

	PlayerMovement playerMovement;

	//PlayerShooting playerShooting;
	bool isDead;
	bool damaged;
	bool healed;

	void Awake ()
	{
		playerMovement = GetComponent <PlayerMovement> ();
		currentHealth = startingHealth;
		healthSlider.value = currentHealth;
	}

	void Update ()
	{
		

		if(damaged)
		{
			damageImage.color = flashColour;
		}
		else
		{
			damageImage.color = Color.Lerp (damageImage.color, Color.clear, flashSpeed * Time.deltaTime);
		}
		damaged = false;
	}

	public void TakeDamage (int amount)
	{
		damaged = true;

		currentHealth -= amount;

		healthSlider.value = currentHealth;

		if(currentHealth <= 0 && !isDead)
		{
			Death ();
		}
	}

	public void Heal(int amount){

		currentHealth += amount;
		if (currentHealth > 100) {
			currentHealth = 100;
		}
		healthSlider.value = currentHealth;

		

	}

	void Death ()
	{
		isDead = true;
		playerMovement.enabled = false;
		;
	}
}
