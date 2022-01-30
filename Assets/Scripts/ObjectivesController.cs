using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ObjectivesController : MonoBehaviour
{
    public List<GameObject> listObjectives;
    public int amountObjectives = 4;
    public GameObject prefabObjective;
    public Painting painter;

    void Awake()
    {
        painter = gameObject.GetComponent<Painting>();

        int amountObjectiveslocal = amountObjectives;
        if (GameManager.singleton != null)
        {
            amountObjectiveslocal = amountObjectives + GameManager.singleton.gamesWon * amountObjectives;
        }
        
        listObjectives = new List<GameObject>();
        for (int i = 0; i < amountObjectiveslocal; i++)
        {
            PlaceObjective();
        }
        painter.isPainting = true;
    }

    // Start is called before the first frame update
    void Start()
    {
        GameManager.singleton.objectiveCount = listObjectives.Count;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void PlaceObjective()
    {
        int randomX = UnityEngine.Random.Range(0,100);
        int randomY = UnityEngine.Random.Range(0,50);
        var aGameObject = Instantiate(prefabObjective, new Vector3((float) -0.5f + (randomX*0.01f),(float)-0.25f+(randomY*0.01f), -1), Quaternion.identity);
        aGameObject.transform.parent = gameObject.transform;
        aGameObject.GetComponent<ObjectiveSensor>().painter=painter;
        listObjectives.Add(aGameObject);
    }
}