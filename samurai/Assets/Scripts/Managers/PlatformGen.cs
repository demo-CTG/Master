using UnityEngine;
using System.Collections;

public class PlatformGen : MonoBehaviour {

	[SerializeField]
	GameObject platform1;
	[SerializeField]
	GameObject[] platforms;
	[SerializeField]
	Transform generationPoint,maxHeightPoint;
	[SerializeField]
	float distanceBetween,platformDistanceMin,platformDistanceMax,maxHeight,maxHeightChange,heightChange,minHeight;
	[SerializeField]
	int platformSelector,platfromSelector;
	[SerializeField] 
	float[] platformsWidths;

	private float platformWidth;

	// Use this for initialization
	void Start () {
		//platformWidth = platform1.GetComponent<BoxCollider> ().size.x;
		platformsWidths = new float[platforms.Length];
		for (int i = 0; i < platforms.Length; i++) {
			platformsWidths [i] = platforms [i].GetComponent<BoxCollider2D> ().size.x;
		}
		minHeight = transform.position.y;
		maxHeight = maxHeightPoint.position.y;
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.position.x < generationPoint.position.x) {
			NewPlatform (distanceBetween, 0);
		}
	}
	void NewPlatform(float distanceBetween, float height){
		platformSelector = Random.Range (0, platforms.Length);
		distanceBetween = Random.Range (platformDistanceMin, platformDistanceMax);
		heightChange = transform.position.y + Random.Range (maxHeightChange,-maxHeightChange);
		if (heightChange > maxHeight) {
			heightChange = maxHeight;
		} else if (heightChange < minHeight) {
			heightChange = minHeight;
		}
		transform.position = new Vector3 (transform.position.x + (platformsWidths[platformSelector] / 2) + distanceBetween, heightChange, transform.position.z);
		Instantiate (platforms[platformSelector], transform.position, transform.rotation);
	}
}
