using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projection : MonoBehaviour
{

    private GameObject cookieLight;
    private GameObject cookieLight2;
    private GameObject cookieLight3;
    private GameObject car;
    Light light1;
    Light light2;
    Light light3;
    private GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        
        cookieLight = GameObject.Find("Light Projection Drive");
        cookieLight2 = GameObject.Find("Light Projection Drive (1)");
        cookieLight3 = GameObject.Find("Light Projection Stay");
        light1 = GameObject.Find("Light Projection Drive").GetComponent<Light>();
        light2 = GameObject.Find("Light Projection Drive (1)").GetComponent<Light>();
        light3 = GameObject.Find("Light Projection Stay").GetComponent<Light>();
        car = GameObject.Find("Car");
        player = GameObject.Find("Player");
        cookieLight.SetActive(true);
        cookieLight2.SetActive(true);
        cookieLight3.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        float x = GetCar();

        if (x >= 211 || x <= 195)
        {
            cookieLight.SetActive(false);
            cookieLight2.SetActive(false);
            cookieLight3.SetActive(false);
            

        }
        else if (x < 205 && x > 200)
        {
            cookieLight.SetActive(true);
            cookieLight2.SetActive(true);
            cookieLight3.SetActive(false);

            light1.color = Color.yellow;
            light2.color = Color.yellow;

            
        }
        else if (x <= 200)
        {

            cookieLight.SetActive(false);
            cookieLight2.SetActive(false);
            cookieLight3.SetActive(true);

            if (player.transform.position.z <= -228)
            {
               
            }
            else if (player.transform.position.z <= -226 && player.transform.position.z > -228)
            {
                light3.color = Color.red;

            }
            else { }

        }
        else
        {
            cookieLight.SetActive(true);
            cookieLight2.SetActive(true);

            light1.color = Color.red;
            light2.color = Color.red;

           
        }
    }

    float GetCar()
    {
        return car.transform.position.x;
    }
}
