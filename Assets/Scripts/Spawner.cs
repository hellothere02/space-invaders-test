using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject enemyPref;
    private Vector2 pointToSpawn;
    [SerializeField] private List<GameObject> enemyOnScene;

    public List<GameObject> EnemyOnScene
    {
        get => enemyOnScene;
        set => enemyOnScene = value;
    }

    private void Awake()
    {
        for (float y = 0; y < 11; y += 2)
        {
            for (float x = -7; x < 7; x += 1.5f)
            {
                pointToSpawn = new Vector2(x, y);
                GameObject currentEnemy = Instantiate(enemyPref, pointToSpawn, Quaternion.identity);
                if (currentEnemy != null)
                {
                    EnemyOnScene.Add(currentEnemy);
                    currentEnemy.transform.SetParent(this.transform);
                }
            }
        }
    }
}
