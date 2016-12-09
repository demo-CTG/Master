using UnityEngine;
using System.Collections;

public class FanScript : MonoBehaviour {
	[SerializeField]
	float fanSpeed;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate (Vector3.forward * fanSpeed * Time.deltaTime);
	}
}
