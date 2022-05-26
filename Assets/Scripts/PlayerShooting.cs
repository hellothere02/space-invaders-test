using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    [SerializeField] protected Transform gunPos;
    [SerializeField] private GameObject projectilePref;
    [SerializeField] protected float delayBetweenShots;

    protected float lastShotTime =0;

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Fire();
        }
    }

    public void Fire()
    {
        if(Time.time - lastShotTime < delayBetweenShots)
        {
            return;
        }
        else
        {
            Instantiate(projectilePref, gunPos.position, Quaternion.identity);
            lastShotTime = Time.time;
        }
    }
}
