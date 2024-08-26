using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDetection : MonoBehaviour
{
    public LevelLoader levelLoader;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            levelLoader.ReloadLevel();
        }

        //Destroy(collision.gameObject, 1f);
    }
}
