using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patient : MonoBehaviour
{
    [SerializeField] Transform explosion;
    [SerializeField] float explosionDuration;
    void OnTriggerEnter2D(Collider2D theCollision)
    {
        if (theCollision.gameObject.name.Contains("Mask"))
        {
            Destroy(this.gameObject);

            GameObject exploder = ((Transform)Instantiate(explosion, this.transform.position, this.transform.rotation)).gameObject;
            Destroy(exploder, explosionDuration);

            GameManager controller = GameObject.FindGameObjectWithTag("GameController").GetComponent("GameManager") as GameManager;
            controller.KilledEnemy();
        }

    }
}