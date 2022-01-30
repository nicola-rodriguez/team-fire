using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<TextMeshProUGUI>().text =
            Math.Truncate(((double)GameManager.singleton.amountOfObjectives / (double)GameManager.singleton.countOfPainted)*100000).ToString();
    }
    
    // Update is called once per frame
    void Update()
    {
    
    }
}
