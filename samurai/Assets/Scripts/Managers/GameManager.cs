using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {
	[SerializeField]
	private Transform checkPoint;
	[SerializeField]
	private float roundTimeLimit;
	[SerializeField]
	GameObject quitButton;
	private float timer;

	// Use this for initialization
	void Start () {
		timer = 0;
	}
	
	// Update is called once per frame
	void Update () {
		timer += Time.deltaTime;
		if (timer >= roundTimeLimit) {
			StartTheFall ();
		}
		if (Input.GetKeyDown (KeyCode.Escape)) {
			PauseMenu ();
		}
	}
	void StartTheFall(){

	}
	void PauseMenu(){
		quitButton.SetActive (true);
	}
}
