using UnityEngine;
using System.Collections;

public class WallJump : MonoBehaviour {
	public bool canWallJump;

	void OnCollisionEnter2D(Collision2D other){
		if (other.gameObject.tag == "Wall")
			canWallJump = true;
	}
	void OnCollisionStay2D(Collision2D other){
		
	}
	void OnCollisionExit2D(Collision2D other){
		if (other.gameObject.tag == "Wall")
			canWallJump = false;
	}
}
