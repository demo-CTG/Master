using UnityEngine;
using System.Collections;

public class CityLayerMovement : MonoBehaviour {
	[SerializeField]
	GameObject[] cities;

	[SerializeField]
	float citySpeed;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (-transform.right * citySpeed * Time.deltaTime);
	}
}
