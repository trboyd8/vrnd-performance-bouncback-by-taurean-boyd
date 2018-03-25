﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trampoline : MonoBehaviour {

    public ParticleSystem pSystem;
    public GameManager gameManager;

	// Use this for initialization
	void Start () {
        pSystem = GetComponentInChildren<ParticleSystem>();
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.CompareTag("Throwable"))
        {
            //Score Point
            gameManager.score++;

            //Particle effect
            pSystem.Play();
        }

    }
}
