using UnityEngine;
using System.Collections;

public class CloudLayerMovement : MonoBehaviour {
	[SerializeField]
	GameObject[] clouds;
	[SerializeField]
	Transform cloudRespawnPoint;
	[SerializeField]
	float cloudspeed;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (-transform.right * cloudspeed* Time.deltaTime);
	}
}
