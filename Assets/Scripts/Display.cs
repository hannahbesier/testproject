using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Animations;

public class Display : MonoBehaviour
{

    private GameObject car;
    private GameObject player;
    private GameObject display;
    private Animator animator;
    private bool stop;
    private bool start;

    // Start is called before the first frame update
    void Start()
    {
        car = GameObject.Find("Car");
        player = GameObject.Find("Player");
        display = GameObject.Find("Display");
        animator = display.GetComponent<Animator>();
        stop = false;
        start = false;
    }

    // Update is called once per frame
    void Update()
    {

        float x = GetCar();
        if (x <= 210.5 && x > 210.4 && start == false)
        {

            animator.SetTrigger("Start");
          //  stop = false;
            start = true;

        }
        if (player.transform.position.z <= -226 && player.transform.position.z > -228 /* x <= 200.4 && x >= 199.9*/ && stop == false)
        {

            animator.SetTrigger("Stop");
            stop = true;
            
        }
    }

    float GetCar()
    {
        return car.transform.position.x;
    }
}
