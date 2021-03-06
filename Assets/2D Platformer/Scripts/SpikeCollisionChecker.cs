using System;
using System.Collections;
using System.Collections.Generic;
using Platformer;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SpikeCollisionChecker : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            other.GetComponent<PlayerMovement>().PlayerDeath();
        }
    }
}
