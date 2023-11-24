using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIDisplay : MonoBehaviour
{
    Pinball pinball;

    [SerializeField] TextMeshProUGUI playerLivesUI;
    [SerializeField] TextMeshProUGUI playerTimeUI;
 
    [SerializeField] Canvas GameOverCanvas;

    private void Awake()
    {
        pinball = FindObjectOfType<Pinball>();
        playerLivesUI = FindObjectOfType<TextMeshProUGUI>();


    }

    // Start is called before the first frame update
    void Start()
    {

        playerLivesUI.text = "SCORE: " + (pinball.GetPlayerLives()).ToString("00");
    }

    // Update is called once per frame
    void Update()
    {
        PlayerStatusUI();

    }

    void PlayerStatusUI()
    {
        playerLivesUI.text = "LIVES: " + (pinball.GetPlayerLives()).ToString("00");


        if (pinball.GetPlayerStatus() == true)
        {


            GameOverCanvas.gameObject.SetActive(true);
        }
    }


}
