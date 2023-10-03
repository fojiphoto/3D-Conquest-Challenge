using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public static Player Instance;

    public GameObject playerBullet;

    private void Awake()
    {
        Instance = this;
    }

    public void Shoot(Transform target)
    {
        GameObject bullet = Instantiate(playerBullet, transform.position, Quaternion.identity) as GameObject;
        bullet.GetComponent<Bullet>().SetTarget(target);
    }
}
