using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShooting : PlayerShooting
{
    private float chanceToShoot;

    private void Awake()
    {
        lastShotTime = 0;
        delayBetweenShots = Random.Range(5, 35);
    }
    private void Update()
    {
        RaycastHit2D hit = Physics2D.Raycast(gunPos.position, transform.TransformDirection(Vector2.down), 5f);
        if (hit.collider == null)
        {
                Fire();
        }
    }
}
