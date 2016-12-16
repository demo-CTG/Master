using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour {

	[SerializeField]
	GameObject healthBar;
	[SerializeField]
	float maxHeatlh, fanHitForce;

	private float currentHealth;
	private Rigidbody2D rb;

	void Start () {
		rb = GetComponent<Rigidbody2D> ();
		currentHealth = maxHeatlh;
		//InvokeRepeating("DecreaseHealth", 1f, 1f);
	}
	
	void DecreaseHealth()
	{
		currentHealth -= 10;
		float newHealth = currentHealth / maxHeatlh;
		SetHealthBar(newHealth);
	}
	void SetHealthBar(float myHealth)
	{
		//myHealth value 0-1
		healthBar.transform.localScale = new Vector3(myHealth, healthBar.transform.localScale.y, healthBar.transform.localScale.z);
	}
	void OnTriggerEnter2D(Collider2D other){
		if (other.tag == "Enemy") {
			DecreaseHealth ();
		}
		if (other.tag == "Laser") {
			LaserDamage ();
		}
		if (other.tag == "Spike")
			SpikeDamage ();
		if (other.tag == "Fan") {
			FanDamage ();
			rb.velocity = new Vector2(rb.velocity.x * fanHitForce,fanHitForce);
		}	
		if (other.tag == "Shuriken") {
			ShurikenDamage ();
		}
	}
	void LaserDamage(){
		float laserDamage;
		float newHealth;
		laserDamage = 25;
		currentHealth = currentHealth - laserDamage;
		newHealth = currentHealth / maxHeatlh;
		SetHealthBar (newHealth);

	}
	void SpikeDamage(){
		float spikeDamage;
		float newHealth;
		spikeDamage = 15;
		currentHealth = currentHealth - spikeDamage;
		newHealth = currentHealth / maxHeatlh;
		SetHealthBar (newHealth);
	}
	void FanDamage(){
		float fanDamage;
		float newHealth;
		fanDamage = 50;
		currentHealth = currentHealth - fanDamage;
		newHealth = currentHealth / maxHeatlh;
		SetHealthBar (newHealth);
	}
	void ShurikenDamage(){
		float shurikenDamage;
		float newHealth;
		shurikenDamage = 10;
		currentHealth = currentHealth - shurikenDamage;
		newHealth = currentHealth / maxHeatlh;
		SetHealthBar (newHealth);
	}
}
