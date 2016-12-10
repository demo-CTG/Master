using UnityEngine;
using System.Collections;

public class Shuriken : MonoBehaviour {
	
	[SerializeField]
	float shurikenThrust;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (-transform.right * shurikenThrust);
	}
	IEnumerator Despawn(){
		yield return null;
	}
	void OnTriggerEnter2D(Collider2D other){
		if (other.tag == "Player") {
			this.gameObject.SetActive (false);
		}
	}
}
