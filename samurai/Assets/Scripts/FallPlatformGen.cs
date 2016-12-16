using UnityEngine;
using System.Collections;

public class FallPlatformGen : MonoBehaviour {

    [SerializeField]
    GameObject[] coinBunches;
    [SerializeField]
    Transform generationPoint;
    [SerializeField]
    float distanceBetween, platformDistanceMin, platformDistanceMax, maxWidth, maxWidthChange, widthChange, minWidth;
    [SerializeField]
    int platformSelector;
    [SerializeField]
    float[] platformWidths;

    private float platformWidth;

    void Start()
    {
        //platformWidths = new float[fallPlatforms.Length];
        //for(int i = 0; i<fallPlatforms.Length; i++)
        //{
        //    platformWidths[i] = fallPlatforms[i].GetComponent<BoxCollider2D>().size.y;
        //}
        //platformWidths = coinBunches.GetComponent<BoxCollider2D>().size.y;
    }
    void Update()
    {
        if(transform.position.y > generationPoint.position.y)
        {
            NewPlatform(distanceBetween, 0);    
        }
    }
    void NewPlatform(float distanceBetween, float width)
    {
        //platformSelector = Random.Range(fallPlatforms.Length, 0);
        //distanceBetween = Random.Range(platformDistanceMin, platformDistanceMax);
        //widthChange = transform.position.x + Random.Range(maxWidthChange, -maxWidthChange);
        //if(widthChange > maxWidth)
        //{
        //    widthChange = minWidth;
        //}
        transform.position = new Vector2(widthChange, transform.position.y + (platformWidths[platformSelector] / 2) + distanceBetween);
        Instantiate(coinBunches[platformSelector], transform.position, transform.rotation);
    }
}
