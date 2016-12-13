using UnityEngine;
using System.Collections;

public class playerFallScript : MonoBehaviour {
    public float fallSpeed;
    private Rigidbody2D myRigidbody;
    private Collider2D myCollider;
    public float horizMoveSpeed;
    float horizontal;


    // Use this for initialization
    void Start () {
        myRigidbody = GetComponent<Rigidbody2D>();
        myCollider = GetComponent<Collider2D>();
         
}
	


    void Update(){
      myRigidbody.velocity = new Vector2(fallSpeed, myRigidbody.velocity.x);

        horizontal = Input.GetAxis("Horizontal");
        print(horizontal);
        myRigidbody.velocity = new Vector2(horizontal,0) * horizMoveSpeed * Time.deltaTime;

        //if (Input.GetKeyDown(KeyCode.A))
        //{
        //    // myRigidbody.velocity = new Vector3.right * speed * 2* Time.deltaTime
        //    myRigidbody.transform.Translate(Vector3.right * horizMoveSpeed * Time.deltaTime);
        //    GetComponent<Rigidbody>().transform.eulerAngles=new Vector2(0,0);
        //}
    }
}
