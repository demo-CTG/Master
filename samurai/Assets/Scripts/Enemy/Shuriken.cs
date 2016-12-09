using UnityEngine;
using System.Collections;

public class Shuriken : MonoBehaviour {
	Rigidbody2D rb;
	[SerializeField]
	float shurikenThrust, timeBetweenAttacks;

	[SerializeField]
	GameObject yakuza;
	// Use this for initialization
	void Start () {
		//canThrow = GameObject.FindGameObjectWithTag("Enemy").GetComponent<YakuzaScript>();
		rb = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {
	//	if (canThrow.shooting) {
	//		rb.velocity = new Vector2 (shurikenThrust, rb.velocity.y);
	//	}
	}
	IEnumerator SwitchShootingFalse(){
		yield return new WaitForSeconds (timeBetweenAttacks);
	//	canThrow.shooting = false;
	}
}
