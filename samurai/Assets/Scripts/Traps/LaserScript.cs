using UnityEngine;
using System.Collections;

public class LaserScript : MonoBehaviour {
	[SerializeField]
	private GameObject laser;
	[SerializeField]
	float laserTimerOn;

	private float timer = 0;

	private bool laserOn;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		timer += Time.deltaTime;
		if (laserOn && timer > laserTimerOn) {
			laserOn = false;
			laser.gameObject.SetActive (laserOn);
			timer = 0;
		}
		if (!laserOn && timer > laserTimerOn) {
			laserOn = true;
			laser.gameObject.SetActive (laserOn);
			timer = 0;
		}
	}
}
