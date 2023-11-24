using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Pinball : MonoBehaviour
{
    [SerializeField] int playerLives = 5;

    [SerializeField] float xValue = 1f;
    [SerializeField] float zValue = 1f;

    bool isDead = false;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Walls") && playerLives > 1)
        {
            playerLives --;
            Debug.Log("You hit the wall");
            Debug.Log("You have hurt the ball");
        } 
        else if (playerLives <= 1 && isDead == false)
        {
            playerLives--;
            isDead = true;

            Debug.Log("You have killed the ball");
        }
    }

    private void Start()
    {
        
    }

    private void Update()
    {
        if(isDead == false)
        {
        MoveAround();

        } else { return; }

    }

    void MoveAround()
    {
        float xAxis = Input.GetAxis("Horizontal") * xValue * Time.deltaTime;
        float zAxis = Input.GetAxis("Vertical") * zValue * Time.deltaTime;

        Vector3 pinballMovement = new Vector3(xAxis, 0, zAxis);

        transform.position += pinballMovement;
        //transform.Translate(xAxis, 0, zAxis);

    }

    public int GetPlayerLives()
    {
        return playerLives;
    }

    public bool GetPlayerStatus()
    {
        return isDead;
    }
}
