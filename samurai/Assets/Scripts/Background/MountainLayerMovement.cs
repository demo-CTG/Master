using UnityEngine;
using System.Collections;

public class MountainLayerMovement : MonoBehaviour {
	[SerializeField]
	GameObject mountain;
	[SerializeField]
	float mountainSpeed;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (-transform.right * mountainSpeed * Time.deltaTime);
	}
}
