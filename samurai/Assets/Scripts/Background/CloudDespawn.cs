using UnityEngine;
using System.Collections;

public class CloudDespawn : MonoBehaviour {
	[SerializeField]
	GameObject otherClouds;
	[SerializeField]
	Vector3 offset;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerEnter2D(Collider2D other){
		if (other.tag == "CloudDeactivationPoint") {
			this.gameObject.transform.position = new Vector3 (otherClouds.transform.position.x + offset.x, otherClouds.transform.position.y, otherClouds.transform.position.z);
		}
	}
}
