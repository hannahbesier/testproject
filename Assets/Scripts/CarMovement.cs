using System;
using System.Collections;
using System.Collections.Generic;
using System.Net;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor;

public class CarMovement : MonoBehaviour
{
    [SerializeField] public float movementSpeed = 10f;
    [SerializeField] private float rotationSpeed = 20f;
    [SerializeField] private float fallDistance = 3f;
    [SerializeField] private float spawnHeight = 1f;
 


    private GameObject car;
    private GameObject player;
    private GameObject wheelFL;
    private GameObject wheelFR;
    private GameObject wheelRL;
    private GameObject wheelRR;

    // Start is called before the first frame update
    void Start()
    {
        Respawn();
     
        car = GameObject.Find("Car");
        player = GameObject.Find("Player");

        wheelFL = GameObject.Find("Wheel_FL");
        wheelFR = GameObject.Find("Wheel_FR");
        wheelRL = GameObject.Find("Wheel_RL");
        wheelRR = GameObject.Find("Wheel_RR");
    }

    // Update is called once per frame
    void Update()
    {

        transform.Translate(Vector3.forward * Time.deltaTime * movementSpeed);
     

        float x = GetCar();
       
        if (x >= 211 || x <= 195)
        {
       
            movementSpeed = 4;

        }
        else if (x < 205 && x > 200)
        {
      
            movementSpeed = 2;
        }
        else if (x <= 200)
        {

            if (player.transform.position.z <= -228)
            {
                movementSpeed = 2;
            }
            else if (player.transform.position.z <= -226 && player.transform.position.z > -228)
            {
          

            }
            else { movementSpeed = 0; }

        }
        else
        {
            movementSpeed = 3;
        }



        wheelFL.transform.Rotate(movementSpeed * 40 * Time.deltaTime, 0, 0);
        wheelFR.transform.Rotate(-movementSpeed * 40 * Time.deltaTime, 0, 0);
        wheelRL.transform.Rotate(movementSpeed * 40 * Time.deltaTime, 0, 0);
        wheelRR.transform.Rotate(-movementSpeed * 40 * Time.deltaTime, 0, 0);
    }
    float GetCar()
    {
        return car.transform.position.x;
    }
    public float GetMovementSpeed()
    {
        return movementSpeed;
    }
  
   

    private void Respawn()
    {
        //  Vector3 thePosition = transform.TransformPoint(localPosition(231.2396), (float)342.06, (float)-215.748);
        //  transform.position = thePosition;
      //  transform.localPosition = new Vector3(0, 0, 0);
    }


}
