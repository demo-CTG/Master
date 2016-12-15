using UnityEngine;
using System.Collections;

public class yakuzaScript : MonoBehaviour {
	public enum State
	{
		PATROL,
		ATTACK,
	}
	public State state;
	private bool alive;
    
	//chase variables

	//attack varaibles
	[SerializeField]
	Transform gunBarrel;
	[SerializeField]
	GameObject player;
	[SerializeField]
	GameObject[] shurikens;
	[SerializeField]
	float timeBetweenAttacks, maxShurikens;

	private float currentShuriken;
	private int shurikenCounter = 0;
	// Use this for initialization
	void Start () {
		state = yakuzaScript.State.PATROL;
		alive = true;
		StartCoroutine ("FSM");
	}
	IEnumerator FSM(){
		while (alive) {
			switch (state) {
			case State.PATROL:
				Patrol ();
				break;
			case State.ATTACK:
				StartCoroutine ("Attack");
				break;
			}
			yield return null;
		}
	}
	void Patrol(){
		print ("patrolling");
	}
	IEnumerator Attack(){
		print ("Attack");
		shurikens [shurikenCounter].SetActive (true);
		shurikens [shurikenCounter].transform.position = gunBarrel.transform.position;
		yield return new WaitForSeconds (timeBetweenAttacks);
		shurikenCounter++;


	//	if (currentShuriken <= maxShurikens) {
	//		shurikenCounter++;
	//	} else if (currentShuriken > maxShurikens) {
	//		state = yakuzaScript.State.PATROL;
	//	}


	}
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerEnter(Collider other){
		if (other.tag == "Player") {
			state = yakuzaScript.State.ATTACK;
		}
	}
	void OnTriggerExit(Collider other){
		if (other.tag == "Player") {
			state = yakuzaScript.State.PATROL;
		}
	}
}
