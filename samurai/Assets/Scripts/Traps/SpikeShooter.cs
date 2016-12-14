using UnityEngine;
using System.Collections;

public class SpikeShooter : MonoBehaviour {

	private float timer;
	private int spike;
	[SerializeField]
	GameObject[] spikes;
	[SerializeField]
	float timeBetweenAttacks;

	public bool shooting = false;
	// Use this for initialization
	void Awake(){
		spike = 0;
		spikes [spike].transform.position = this.gameObject.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		timer += Time.deltaTime;
		if (timer >= timeBetweenAttacks) {
			shooting = true;
			spikes [spike].SetActive (true);
			spike++;
			if (spike == spikes.Length)
				spike = 0;
			timer = 0;

		}
	}
}
