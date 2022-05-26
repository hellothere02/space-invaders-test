using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerProjectile : MonoBehaviour
{
    [SerializeField] protected int speed;
    protected string target;

    private void Awake()
    {
        Shoot(Vector2.up);
        target = "Enemy";
        Destroy(this.gameObject, 3f);
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag(target))
        {
            Destroy(collision.gameObject);
            Destroy(this.gameObject);
        }
    }

    public void Shoot(Vector2 direction)
    {
        GetComponent<Rigidbody2D>().velocity = direction * speed;
    }
}
