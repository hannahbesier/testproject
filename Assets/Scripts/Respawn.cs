using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{

    private GameObject car;
    // Start is called before the first frame update
    void Start()
    {
        car = GameObject.Find("Car");
        car.transform.localPosition = new Vector3(0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
