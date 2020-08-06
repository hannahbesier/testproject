using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    [SerializeField] private float movementSpeed = 10f;
    [SerializeField] private float rotationSpeed = 180f;
    [SerializeField] private float fallDistance = 3f;
    [SerializeField] private float spawnHeight = 1f;
    [SerializeField] private Transform planeTransform = null;

    private float movementDirection;
    private Vector3 rotationDirection;

    // Start is called before the first frame update
    void Start()
    {
        movementDirection = 0f;
        rotationDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
    }

    // Update is called once per frame
    void Update()
    {
        rotationDirection.y = Input.GetAxis("Horizontal");
        movementDirection = (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow)) ? 1 : 0;
        transform.Translate(Vector3.back * Time.deltaTime * movementSpeed*movementDirection);
       
        transform.Rotate(rotationDirection*rotationSpeed*Time.deltaTime);
    }
}
