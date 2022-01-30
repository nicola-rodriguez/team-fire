using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class ControllerPositioning : MonoBehaviour
{
    public Transform myTarget;

    // Start is called before the first frame update
    void Start()
    {
  
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(-myTarget.position.x, myTarget.position.y, -2f);
    }

    
}
