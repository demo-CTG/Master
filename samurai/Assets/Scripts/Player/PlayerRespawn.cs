using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class PlayerRespawn : MonoBehaviour {
	[SerializeField]
	Transform checkPoint;
	[SerializeField]
	GameObject player;
	[SerializeField]
	private string startMenu;

	void OnTriggerEnter(Collider other){
		if (other.tag == "KillBox") {
			SceneManager.LoadScene (startMenu);
		}			
	}
}
