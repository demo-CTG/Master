using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {
	//loco variables
	
    public float playerSpeed;//this float effects the players speed
	[SerializeField]
	float jumpForce,dblJumpForce, wallJumpForce, pushOffWallForce,gravityAfterLimit, timeUntilLerpBAck, lerpBackSpeed;//this is how the player jumps and will need to be multiplied x2 in the inspector when a double jump is used
	[SerializeField]
	int wallJumpCount = 0;
	private int jumpCount, wallJumpMax = 2;
	//ground variables
	[SerializeField]
    bool grounded;//sets the ground so that the player can be connected to whatever the ground is
	[SerializeField]
	LayerMask whatIsGround;
	//attack
	[SerializeField]
	KeyCode attackKey;
	[SerializeField]
	float attackDistance;
	[SerializeField]
	Transform attackPoint,lerpBack;
	//collecting the coins variables
	[SerializeField]
	int coinCounter = 0;
	[SerializeField]
	Text coinsText;

	WallJump wallJump;
	private Collider2D myCollider;
	private Rigidbody2D myRigidbody;
    private bool lerpingBack = false;
    private bool start = false;
    private Transform startPos;
    Animator anim;
    void Start () {
        anim = GetComponent<Animator>();
		coinCounter = 0;
		UpdateGui ();
		wallJump = GetComponentInChildren<WallJump> ();
        myRigidbody = GetComponent<Rigidbody2D>();//grabbing the component of the player script and applying the rigid body to it
        myCollider = GetComponent<Collider2D>();//allows you to acess the box collider for detection later on
		grounded = Physics2D.IsTouchingLayers(myCollider,whatIsGround);//this can return true or false on ground detection/set this bitch as a method
	}
	void Update () {
        PlayerMovement();
		
		if (Input.GetKeyDown (attackKey))
			Attack ();
		if(wallJumpCount > wallJumpMax && !grounded)
			myRigidbody.velocity = new Vector2 (0, gravityAfterLimit * wallJumpForce);

		if (wallJump.canWallJump && Input.GetKeyDown (KeyCode.Mouse0)) {
			wallJumpCount++;
			print (wallJumpCount);
			WallJump ();
		}
    }
	void PlayerMovement(){
		myRigidbody.velocity = new Vector2 (playerSpeed, myRigidbody.velocity.y);//This should be done as a method/ player speed is determined by the x and the velocity for the y is seperated
        if (Input.GetKeyDown(KeyCode.Mouse0))
            Jump();
    }
	void Jump(){
		if (grounded) {
			myRigidbody.velocity = new Vector2 (myRigidbody.velocity.x, jumpForce);
			jumpCount++;
			grounded = false;
            anim.SetBool("isJumping",true);
		}else if (!grounded && jumpCount < 2) {
			myRigidbody.velocity = new Vector2 (myRigidbody.velocity.x, jumpForce);
			jumpCount++;
            anim.SetBool("isJumping", false);
		}			
	}
	void Attack(){
		RaycastHit hit;
		if(Physics.Raycast (attackPoint.position, transform.right, out hit, attackDistance)){
			if (hit.collider.tag == "Enemy") {
				print ("hit target");
				Debug.DrawRay (transform.position, hit.point,Color.red, 3f);
                anim.SetBool("isAttacking", true);
			}
		}
	}

	void OnCollisionEnter2D(Collision2D col){//detects if the jump is actually active
        if(col.transform.tag == "Ground"){
            jumpCount = 0;
			wallJumpCount = 0;
			grounded = true;
        }
    }
	void WallJump(){
		myRigidbody.velocity = new Vector2 (-myRigidbody.velocity.x * pushOffWallForce, wallJumpForce);
	}
	void OnTriggerEnter2D(Collider2D other){
		if (other.tag == "Coin") {
			coinCounter++;
			UpdateGui ();
		}
	}
	void UpdateGui(){
		coinsText.text = "Coins: " + coinCounter.ToString();
	}
}