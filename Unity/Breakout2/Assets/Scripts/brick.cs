using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class brick : MonoBehaviour {
    void OnCollisionEnter2D(Collision2D collision)
    {
        var gm = FindObjectOfType<GameManager>();
        gm.bricks.Remove(gameObject);   // Tell GM to remove this brick
        gm.score += 1;                  // Gain a point
        Destroy(gameObject);            // And destroy this brick
    }
}
