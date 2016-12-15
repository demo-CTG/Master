using UnityEngine;
using System.Collections;
[RequireComponent(typeof(AudioClip))]

public class Shuriken : MonoBehaviour {
	
	[SerializeField]
	float shurikenThrust;
    //public AudioClip shurSound;

    
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (-transform.right * shurikenThrust);
       // AudioSource audio = GetComponent<AudioSource>();
       //audio.Play(44100);
        
	}
	IEnumerator Despawn(){
		yield return null;
	}
	void OnTriggerEnter2D(Collider2D other){
		if (other.tag == "Player") {
			this.gameObject.SetActive (false);
		}
	}
}
