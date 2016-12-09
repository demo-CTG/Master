using UnityEngine;
using System.Collections;

public class MountainDespawn : MonoBehaviour {
	[SerializeField]
	GameObject otherMountain;
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
			transform.position = new Vector2 (otherMountain.transform.position.x + offset.x, otherMountain.transform.position.y);
		}
	}
}
