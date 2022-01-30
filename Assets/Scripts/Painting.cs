using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Painting : MonoBehaviour
{
    public List<GameObject> aList;
    public bool isPainting;   
    public GameObject brush;
    public GameObject prefabToPaint;
    private LineRenderer lineRend;
    void Awake()
    {
        aList = new List<GameObject>();
        lineRend = gameObject.GetComponent<LineRenderer>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void LateUpdate()
    {
        if (isPainting)
        {
            var aGameObject = Instantiate(prefabToPaint, brush.transform.position, Quaternion.identity);
            /*
            lineRend.gameObject.SetActive(true);
            lineRend.positionCount = 2;
            int last = aList.Count;
            if (last > 0)
            {
                lineRend.SetPosition(0, aList[last-1].transform.position);
                lineRend.SetPosition(1, aGameObject.transform.position);
            }
            */
            aList.Add(aGameObject);
        }
    }
}
