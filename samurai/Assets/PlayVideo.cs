using UnityEngine;
using System.Collections;

public class PlayVideo : MonoBehaviour
{
    void Start()
    {
        Handheld.PlayFullScreenMovie("samuraiMenu", Color.black, FullScreenMovieControlMode.CancelOnInput);
    }
}
