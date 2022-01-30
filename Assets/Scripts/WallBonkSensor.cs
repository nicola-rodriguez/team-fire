using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallBonkSensor : MonoBehaviour
{
    public AudioSource theAudioSource;
    public AudioClip bonkWallSound;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == LayerMask.NameToLayer("Walls"))
        {

            Debug.Log("bonked a wall!");
            theAudioSource.PlayOneShot(bonkWallSound);
        }
    }
}
