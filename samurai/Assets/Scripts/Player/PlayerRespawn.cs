using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class PlayerRespawn : MonoBehaviour {
	[SerializeField]
	Transform checkPoint;
	[SerializeField]
	GameObject player;
	[SerializeField]
	private string newLevel;

	void OnTriggerEnter(Collider other){
		if (other.tag == "KillBox") {
			transform.position = checkPoint.transform.position;
			//SceneManager.LoadScene (newLevel);
		}			
	}
}
