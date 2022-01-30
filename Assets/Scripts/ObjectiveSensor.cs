using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ObjectiveSensor : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    //Upon collision with another GameObject, this GameObject will reverse direction
    private void OnTriggerEnter2D(Collider2D other)
    {
        this.GetComponent<Collider2D>().enabled = false;
        this.GetComponent<SpriteRenderer>().color = new Color32(13,2,33,255);
        GameManager.singleton.objectiveCount--;
        if (GameManager.singleton.objectiveCount == 0)
        {
            Debug.Log("You won the game!");
            SceneManager.LoadScene("VictoryScene");
        }
    }
}