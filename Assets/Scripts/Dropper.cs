using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstaclesTiming : MonoBehaviour
{

    //[SerializeField] int spawnTimeVariance = 1;
    //[SerializeField] int spawnTimeMinimum = 4;
    //[SerializeField] int spawnTimeMaximum = 7;

    [SerializeField] float delayTime;

    Rigidbody cubeBombRigidbody;
    MeshRenderer cubeBombRenderer;
    

    private void Awake()
    {
        cubeBombRigidbody = GetComponent<Rigidbody>();
        cubeBombRenderer = GetComponent<MeshRenderer>();
    }

    void Start()
    {
        cubeBombRigidbody.useGravity = false;
        cubeBombRenderer.enabled = false;
    }

    void Update()
    {
        if (Time.time > delayTime)
        {
            cubeBombRenderer.enabled = true;
            cubeBombRigidbody.useGravity = true;

            //Invoke("ResetFallingBlocks", 5);

        }
    }

    void ResetFallingBlocks()
    {
        Destroy(gameObject);
    }

    //void FallingBlocksTimer()
    //{
    //    Invoke(SpawnFallingBlocks(), GetRandomSpawnTime());
    //}

    //void SpawnFallingBlocks()
    //{
    //    Instantiate();
    //}

    //int GetRandomSpawnTime()
    //{
    //    // tạo một biến spawnTime Random trong khoảng định trước
    //    int spawnTime = Random.Range(spawnTimeMinimum - spawnTimeVariance, spawnTimeMaximum + spawnTimeVariance);


    //    // clamp các giá trị âm
    //    return Mathf.Clamp(spawnTime, 0, int.MaxValue);
    //}
}
