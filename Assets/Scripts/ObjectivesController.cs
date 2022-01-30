using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectivesController : MonoBehaviour
{
    public List<GameObject> listObjectives;
    public int amountObjectives = 4;
    public GameObject prefabObjective;

    void Awake()
    {
        listObjectives = new List<GameObject>();
        for (int i = 0; i < amountObjectives; i++)
        {
            PlaceObjective();
        }
        GameManager.singleton.objectiveCount = amountObjectives;
    }

    // Start is called before the first frame update
    void Start()
    {
        
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
        listObjectives.Add(aGameObject);
    }
}