﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallDetection : MonoBehaviour
{
    GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("PlayableCharacter");
    }

    // Update is called once per frame
    void Update()
    {
        if(player.transform.position.y <= -10)
        {
            player.transform.position = new Vector3(-6, 1, -1);        }
    }
}
