using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EneyDetection : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(collision.gameObject, 1f);
    }
}
