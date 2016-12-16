using UnityEngine;
using System.Collections;

public class Shuriken : MonoBehaviour {
	
	[SerializeField]
	float shurikenThrust;
    Rigidbody2D rb;
	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
        rb.velocity = new Vector2(-shurikenThrust, rb.velocity.y);
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
