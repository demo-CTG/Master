using UnityEngine;
using System.Collections;

public class coinGen : MonoBehaviour {
	[SerializeField]
	GameObject coin;
	[SerializeField]
	float timer, timeBetweenSpawns;


	// Use this for initialization
	void Start () {
		timer = 0;
	}
	
	// Update is called once per frame
	void Update () {
		timer += Time.deltaTime;
		if (timer > timeBetweenSpawns) {
			GenCoin ();
			timer = 0;
		}
	}
	void GenCoin(){
		Instantiate (coin, transform.position, transform.rotation);
	}
}
