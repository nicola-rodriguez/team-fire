using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Painting : MonoBehaviour
{
    public List<GameObject> aList;
    public bool isPainting;   
    public GameObject brush;
    public GameObject prefabToPaint;
    void Awake()
    {
        aList = new List<GameObject>();
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
            Instantiate(prefabToPaint, brush.transform.position, Quaternion.identity);
            aList.Add(prefabToPaint);
        }
    }
}
