﻿using UnityEngine;
using System.Collections;

public class PlatformActivator : MonoBehaviour {

    public Collider2D[] platforms;
    public Character_Controller player;


	void Update ()
    {
        if (player.GetComponent<Rigidbody2D>().velocity.y > 0) //moving up, deactivate
        {
            foreach (Collider2D col in platforms)
                col.enabled = false;
        }
        else
        {
            foreach (Collider2D col in platforms) //moving down
                col.enabled = true;
        }
	}
}
