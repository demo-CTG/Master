using UnityEngine;
using System.Collections;

public class PlatformScript : MonoBehaviour {

	GameObject deactivationPoint;
	// Use this for initialization
	void Start () {
		deactivationPoint = GameObject.FindGameObjectWithTag ("DeactivationPoint");
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.position.x < deactivationPoint.transform.position.x)
			Deactivate ();
	}
	void Deactivate(){
		gameObject.SetActive (false);
	}
}
