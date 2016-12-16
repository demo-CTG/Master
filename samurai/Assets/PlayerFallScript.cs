using UnityEngine;
using System.Collections;

public class PlayerFallScript : MonoBehaviour {
    [SerializeField]
    float moveX, movementSpeed;
    Rigidbody2D rb;
	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void FixedUpdate () {
        moveX = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(moveX * movementSpeed, rb.velocity.y);
	}
}
