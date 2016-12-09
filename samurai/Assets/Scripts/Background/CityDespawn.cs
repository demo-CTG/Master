using UnityEngine;
using System.Collections;

public class CityDespawn : MonoBehaviour {
	[SerializeField]
	GameObject otherCity;
	[SerializeField]
	Vector3 offset;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerEnter2D(Collider2D other){
		if (other.tag == "DeactivationPoint") {
			this.gameObject.transform.position = new Vector3 (otherCity.transform.position.x + offset.x, otherCity.transform.position.y, otherCity.transform.position.z);
		}
	}
}
