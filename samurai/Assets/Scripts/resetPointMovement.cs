using UnityEngine;
using System.Collections;

public class resetPointMovement : MonoBehaviour {
    [SerializeField]
    float speed;
    

	// Use this for initialization
	void Start () {
        
       
    }
	
	// Update is called once per frame
	void FixedUpdate () {
        transform.Translate(transform.right * speed * Time.deltaTime);
	}
}
