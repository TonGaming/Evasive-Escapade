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
    
    

    private void Awake()
    {
        cubeBombRigidbody = GetComponent<Rigidbody>();

    }

    void Start()
    {
        
    }

    void Update()
    {
        if (Time.time > delayTime)
        {
            cubeBombRigidbody.mass = 1;

            Invoke("ResetFallingBlocks", 5);

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
