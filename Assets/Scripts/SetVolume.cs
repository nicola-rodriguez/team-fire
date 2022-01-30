using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetVolume : MonoBehaviour
{
    public void adjustVolume()
    {
        GameManager.singleton.GetComponent<AudioSource>().volume = gameObject.GetComponent<Slider>().value;
    }
}
