﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Ryan and Jeremy 
//will need to be commented with every function


public class InventoryBehaviour : MonoBehaviour
{
    public Canvas canvas;
    

    //this is just to open up the menu to mess around with the players items
    public void OpenInventory()
    {
        if (Input.GetButton("ViewButton"))
        {
            canvas.enabled = true;
            Time.timeScale = 0.0f;
        }
    }

    // Update is called once per frame
    void Update()
    {
        OpenInventory();
    }
}
