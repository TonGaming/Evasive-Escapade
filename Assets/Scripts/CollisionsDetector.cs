using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionsDetector : MonoBehaviour
{
    MeshRenderer wallsRenderer;

    // Start is called before the first frame update
    void Start()
    {
            wallsRenderer = GetComponent<MeshRenderer>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player") && wallsRenderer.gameObject.tag != "Hit")
        {
            wallsRenderer.material.color = Color.red;
            wallsRenderer.gameObject.tag = "Hit";
        }
    }
}
