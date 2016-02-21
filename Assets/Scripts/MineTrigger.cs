using UnityEngine;
using System.Collections;

public class MineTrigger : MonoBehaviour {

	public int damage;
	GameObject player;
	PlayerHealth playerHealth;
	bool mineActive;
	// Use this for initialization
	void Awake() {
		player = GameObject.FindGameObjectWithTag ("Player");
		playerHealth = player.GetComponent<PlayerHealth> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (mineActive) {
			playerHealth.TakeDamage (damage);
			mineActive = false;
			//Destroy (this);
		}
	}

	void OnTriggerEnter(Collider collide){
		if (collide.CompareTag ("Player")) {
			mineActive = true;
		}
	}
}
