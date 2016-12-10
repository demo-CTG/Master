using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {
	[SerializeField]
	Vector3 cameraOffset;
	[SerializeField]
	GameObject target;

	PlayerController player;
	// Use this for initialization
	void Start () {
		player = GameObject.FindGameObjectWithTag ("Player").GetComponent<PlayerController> ();
		transform.position = new Vector3 (target.transform.position.x + cameraOffset.x, cameraOffset.y,  cameraOffset.z);
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (transform.right *Time.deltaTime* player.playerSpeed );
	}
}
