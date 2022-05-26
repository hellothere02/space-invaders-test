using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Spawner))]

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] private Vector2 targetPos;
    [SerializeField] private float horizontalSpeed = 1;
    [SerializeField] private float verticalSpeed = 2;

    private Spawner spawner;
    private int aliveEnemyCount;

    private void Start()
    {
        spawner = GetComponent<Spawner>();
        aliveEnemyCount = spawner.EnemyOnScene.Count;
        StartCoroutine("GoDown");
    }

    private void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, targetPos, Time.deltaTime * horizontalSpeed);
        if ((Vector2)transform.position == targetPos)
        {
            targetPos.x *= -1;
        }

        if (spawner.EnemyOnScene.Count <= aliveEnemyCount / 2)
        {
            ChangeSpeed();
        }
    }

    private void ChangeSpeed()
    {
        horizontalSpeed += horizontalSpeed;
        aliveEnemyCount = spawner.EnemyOnScene.Count;
    }

    private IEnumerator GoDown()
    {
        yield return new WaitForSeconds(30);
        targetPos.y -= verticalSpeed;
        StartCoroutine("GoDown");
    }
}
