using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetPlayZone : MonoBehaviour
{
    public Camera gameCamera;
    public float chosenHeight;
    public Transform levelBounds;

    // Start is called before the first frame update
    void Awake()
    {
        //get the main camera
        gameCamera = Camera.main;
        //get the chosen height
        chosenHeight = GameManager.singleton.chosenHeight;
        //set height on camera
        gameCamera.orthographicSize = chosenHeight*.5f;
        //scale the level to match the screen
        levelBounds.localScale = new Vector3(((chosenHeight * gameCamera.pixelWidth)/gameCamera.pixelHeight),chosenHeight, 1);
        GameManager.singleton.levelBounds = levelBounds;
    }

    void Start()
    {
    }
}
