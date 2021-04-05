using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float lifetime = 2.0f;
    public float speed = 5.0f;

    public int damage = 1;

    void Start()
    {
        Destroy(gameObject, lifetime);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.up * Time.deltaTime * speed);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name.Contains("Covid") || collision.gameObject.name.Contains("Patient"))
        {
            Destroy(this.gameObject);
        }
    }
}