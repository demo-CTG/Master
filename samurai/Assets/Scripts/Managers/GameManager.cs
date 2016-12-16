using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {
	[SerializeField]
	private Transform checkPoint;
	[SerializeField]
	private float roundTimeLimit, transitionTime;
	[SerializeField]
	GameObject quitButton, wall1,wall2, mainCamera, fallCamera, playerSprite, fallSprite, coins, platformGen, killBox1, killBox2;
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
			StartCoroutine (StartTheFall());
		}
		//if (Input.GetKeyDown (KeyCode.Escape)) {
		//	PauseMenu ();
		//}
	}
	IEnumerator StartTheFall(){
		killBox1.SetActive (false);
		killBox2.SetActive (false);
		platformGen.SetActive (false);
		mainCamera.SetActive (false);
		fallCamera.SetActive (true);
		wall1.SetActive (true);
		wall2.SetActive (true);
		wall1.transform.parent = fallCamera.transform;
		wall2.transform.parent = fallCamera.transform;
		playerSprite.SetActive (false);
		fallSprite.SetActive (true);
		yield return new WaitForSeconds (transitionTime);
		coins.SetActive (true);
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
