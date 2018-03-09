﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Ryan

public class DoorBehaviour : MonoBehaviour
{
    public GameObject player;
    public Animator dooropener;

    void Open()
    {
        if(Input.GetButtonDown("A Button") && Vector3.Distance(player.transform.position, transform.position) < 3)
            dooropener.SetTrigger("open");
    }

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        Open();
	}
}
