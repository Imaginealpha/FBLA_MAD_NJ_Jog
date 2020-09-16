﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KillScript : MonoBehaviour {

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag.Equals("Player"))
        {
            SceneManager.LoadScene("GameOver");
        }
    }
}
