using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IntroScene : MonoBehaviour
{
    public Transform leftHand;
    public Transform rightHand;
    public float leftY;
    public float rightY;
    public float handsDistance;

    private void Update()
    {
        leftY = leftHand.position.y;
        rightY = rightHand.position.y;
        handsDistance = leftY - rightY;
        if(handsDistance < 0)
            handsDistance*= -1; // there's a better way to do this ... I forget ... this works :D
    }

    public void OnSubmit()
    {
        Debug.Log("got the submit action");
        if(handsDistance == 0f)
            handsDistance = 1f;
        SetZoneSize();
    }

    private void SetZoneSize()
    {
        GameManager.singleton.chosenHeight = handsDistance;
        SceneManager.LoadScene("Menu");
    }
}
