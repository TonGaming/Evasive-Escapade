using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;


public class GliderSpinner : MonoBehaviour
{
    [SerializeField] float spiningSpeed = 8;
    UnityEngine.Quaternion rotation;

    // Start is called before the first frame update
    void Start()
    {
         rotation = UnityEngine.Quaternion.Euler(0, 0, spiningSpeed * Time.deltaTime);

    }

    // Update is called once per frame
    void Update()
    {
        transform.rotation *= rotation;
    }
}
