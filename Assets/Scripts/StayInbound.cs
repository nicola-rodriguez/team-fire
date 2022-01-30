using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class StayInbound : MonoBehaviour
{
    public float MAXX = 1f, MAXY = 0.5f, RATIOX = 100f, RATIOY = 100f;
    public float zcoord = -2;

    // Start is called before the first frame update
    void Start()
    {
        MAXX = GameManager.singleton.levelBounds.localScale.x / 2;
        MAXY = GameManager.singleton.levelBounds.localScale.y / 2;
        RATIOX = MAXX/10;
        RATIOY = MAXY/10;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        Transform aTransform = GetComponent<Transform>();
        var x = aTransform.position.x;
        var y = aTransform.position.y;
        
        if (x > MAXX)
        {
            x = MAXX-RATIOX;
        }
        else if (aTransform.position.x < -MAXX)
        {
            x = -MAXX+RATIOX;
        }

        if (y > MAXY)
        {
            y = MAXY-RATIOY;
        }
        else if (y < -MAXY)
        {
            y = -MAXY+RATIOY;
        }

        aTransform.position = new Vector3(x,y,aTransform.position.z);
    }
}
