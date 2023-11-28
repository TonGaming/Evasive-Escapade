using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] float PatrollingSpeed = 10f;

    Rigidbody cubeRigidbody;

    // Start is called before the first frame update
    void Start()
    {
        cubeRigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        PatrollingZ();
    }

    void PatrollingZ()
    {
        Vector3 cubeTransform = new Vector3(0, 0, PatrollingSpeed * Time.deltaTime);

        // manipulating velocity feels stutter and weird
        //cubeRigidbody.velocity = cubeTransform;

        transform.position += cubeTransform;

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("OuterWalls"))
        {
            PatrollingSpeed = -PatrollingSpeed;
        }
    }
}
