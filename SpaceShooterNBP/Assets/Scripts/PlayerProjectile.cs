using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerProjectile : MonoBehaviour
{
    public GameObject projectile_PFB;
    public Transform projectileSpawner;

    private void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Instantiate(projectile_PFB, projectileSpawner.position, Quaternion.identity);
        }
    }
}
