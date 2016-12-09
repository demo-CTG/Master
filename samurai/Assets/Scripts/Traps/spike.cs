using UnityEngine;
using System.Collections;

public class spike : MonoBehaviour {
	Rigidbody2D rb;

	[SerializeField]
	float spikesThrust;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(gameObject.activeSelf == true){
			transform.position -= new Vector3 (spikesThrust, 0);
		}
	}
}
