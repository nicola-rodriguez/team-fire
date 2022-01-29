using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetPlayZone : MonoBehaviour
{
    public Camera gameCamera;
    public Transform levelBounds;
    // Start is called before the first frame update
    void Start()
    {
        //get the main camera
        gameCamera = Camera.main;
        //scale the level to match the screen
        levelBounds.localScale = new Vector3(((10f * gameCamera.pixelWidth)/gameCamera.pixelHeight), 10, 1);
    }
}
