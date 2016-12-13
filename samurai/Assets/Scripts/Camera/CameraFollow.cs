using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {
	[SerializeField]
	Vector3 cameraOffset;
	[SerializeField]
	GameObject target;

    [SerializeField]
    float cameraSpeed;

  
	// Use this for initialization
	void Start () {
		transform.position = new Vector3 (target.transform.position.x + cameraOffset.x, cameraOffset.y,  cameraOffset.z);
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		transform.Translate (transform.right  * Time.deltaTime * cameraSpeed);
	}
}
