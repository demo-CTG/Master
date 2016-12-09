using UnityEngine;
using System.Collections;

public class MoonLayerMovement : MonoBehaviour {
	[SerializeField]
	GameObject moon;
	[SerializeField]
	float moonSpeed;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (-transform.right * moonSpeed * Time.deltaTime);
	}
}
