using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyProjectile : PlayerProjectile
{
    private void Awake()
    {
        Shoot(Vector2.down);
        target = "Player";
        Destroy(this.gameObject, 3f);
    }

    public new void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag(target))
        {
            Destroy(collision.gameObject);
            Destroy(this.gameObject);
        }
    }
}
