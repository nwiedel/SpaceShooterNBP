using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileController : MonoBehaviour
{
    private Rigidbody2D rigidBody2D;
    public Vector2 force;
    public float lifeSpan;

    // Start is called before the first frame update
    void Start()
    {
        rigidBody2D = GetComponent<Rigidbody2D>();
        rigidBody2D.AddForce(force, ForceMode2D.Impulse);

        StartCoroutine(StopProjectile());
    }

    private IEnumerator StopProjectile()
    {
        yield return new WaitForSeconds(lifeSpan);
        Destroy(gameObject);
    }
}
