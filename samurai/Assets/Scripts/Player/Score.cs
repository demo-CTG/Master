using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Score : MonoBehaviour {
	[SerializeField]
	int currentScore;
	[SerializeField]
	Text scoreCounter;

	// Use this for initialization
	void Start (){
		currentScore = 0;
		UpdateScore(currentScore);
	}
	void UpdateScore(int addScore){
		scoreCounter.text = "Score: " + currentScore.ToString ();
	}
	void OnTriggerEnter(Collider other){
		if (other.tag == "Coin") {
			currentScore++;
			UpdateScore(currentScore);
		}
	}
}
