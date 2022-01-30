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
        Rigidbody2D aRigidbody = GetComponent<Rigidbody2D>();
        bool reverse = false;
        var x = transform.position.x;
        var y = transform.position.y;
        
        if (x > MAXX)
        {
            x = MAXX-RATIOX;
            reverse = true;
        }
        else if (x < -MAXX)
        {
            x = -MAXX+RATIOX;
            reverse = true;
        }

        if (y > MAXY)
        {
            y = MAXY-RATIOY;
            reverse = true;
        }
        else if (y < -MAXY)
        {
            y = -MAXY+RATIOY;
            reverse = true;
        }

        if (reverse)
        {
            //aRigidbody.velocity = transform.forward * aRigidbody.velocity.magnitude;
            aRigidbody.AddForce(-aRigidbody.velocity*2);
        }

        transform.position = new Vector3(x,y,transform.position.z);
    }
}
