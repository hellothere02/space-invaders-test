using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    private Spawner spawner;
    private GameObject player;
    private void Awake()
    {
        spawner = GameObject.Find("Spawner").GetComponent<Spawner>();
        player = GameObject.Find("Player");
    }

    private void Update()
    {
        if(spawner.EnemyOnScene.Count < 1 || player == null)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
