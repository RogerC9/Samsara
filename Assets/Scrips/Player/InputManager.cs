using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    private Player player;
    private GameManager gameManager;


    //
    // Use this for initialization
    void Start()
    {
        gameManager = GetComponent<GameManager>();
        
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();


    }

    // Update is called once per frame
    void Update()
    {
        float hAxis = Input.GetAxis("Horizontal");


        player.SetHorizontalAxis(hAxis);

        if (Input.GetButtonDown("Jump"))
        {
            player.StartJump();
        }
        //correr 
        if (Input.GetButtonDown("Fire3"))
        {
            player.isRunning = true;
        }
        //caminar
        if (Input.GetButtonUp("Fire3"))
        {
            player.isRunning = false;
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            player.DashSpeed();
        }
        //dash
        if (Input.GetKeyDown(KeyCode.T))
        {
            gameManager.PressKeyT();
        }
    }
}
