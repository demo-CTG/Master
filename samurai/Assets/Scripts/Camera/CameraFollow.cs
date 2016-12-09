using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {
	[SerializeField]
	Vector3 cameraOffset;
	[SerializeField]
	GameObject target;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = new Vector3 (target.transform.position.x + cameraOffset.x, cameraOffset.y,  cameraOffset.z);
	}
}
