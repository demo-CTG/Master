using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {
	[SerializeField]
	private Transform checkPoint;
	[SerializeField]
	private float roundTimeLimit;
	[SerializeField]
	GameObject quitButton;
	[SerializeField]
	Text timerCounter;
	[SerializeField]
	string newLevel;

	private float timer;

	// Use this for initialization
	void Start () {
		timer = 0;
	}
	
	// Update is called once per frame
	void Update () {
		timer += Time.deltaTime;
		UpdateTimerText ();
		if (timer >= roundTimeLimit) {
			StartOver ();
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
	void UpdateTimerText(){
		timerCounter.text = "Time: " + timer.ToString ();
	}
	void StartOver(){
		SceneManager.LoadScene (newLevel);
	}
}
