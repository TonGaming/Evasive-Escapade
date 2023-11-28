using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;


public class GliderSpinner : MonoBehaviour
{
    [SerializeField] float spiningSpeed = 8;
    //UnityEngine.Quaternion rotation;

    
    void Start()
    {
         //rotation = UnityEngine.Quaternion.Euler(0, 0, spiningSpeed * Time.deltaTime);
         
    }

    
    void Update()
    {
        transform.Rotate(0, 0, spiningSpeed * Time.deltaTime);
        // transform.rotation += rotation;
    }
}
