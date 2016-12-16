using UnityEngine;
using System.Collections;

public class CameraFall : MonoBehaviour {

    [SerializeField]
    Vector3 cameraOffset;
    [SerializeField]
    GameObject target, killBox, wall1, wall2;

    [SerializeField]
    float cameraSpeed;


    // Use this for initialization
    void Start()
    {
        wall1.SetActive(true);
        wall2.SetActive(true);
        //transform.position = new Vector3(target.transform.position.x + cameraOffset.x, target.transform.position.y + cameraOffset.y , cameraOffset.z);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position = new Vector3(cameraOffset.x, target.transform.position.y + cameraOffset.y, cameraOffset.z);
    }
}
