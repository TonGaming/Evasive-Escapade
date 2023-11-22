using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PinballMovement : MonoBehaviour
{
    [SerializeField] float xValue = 1f;
    [SerializeField] float zValue = 1f;



    private void Start()
    {
        
    }

    private void Update()
    {
        MoveAround();

    }

    void MoveAround()
    {
        float xAxis = Input.GetAxis("Horizontal") * xValue * Time.deltaTime;
        float zAxis = Input.GetAxis("Vertical") * zValue * Time.deltaTime;

        Vector3 pinballMovement = new Vector3(xAxis, 0, zAxis);

        transform.position += pinballMovement;
        //transform.Translate(xAxis, 0, zAxis);

    }

}
