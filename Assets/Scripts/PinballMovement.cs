using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PinballMovement : MonoBehaviour
{
    float moveAmount = 0.01f;

    private void Start()
    {
        
    }

    private void Update()
    {
        transform.Translate(0, moveAmount, 0);
    }


}
