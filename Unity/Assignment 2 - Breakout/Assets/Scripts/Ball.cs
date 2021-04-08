using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField] private Vector2 spawnPoint = new Vector2(0, -2);
    [SerializeField] private Vector2 baseSpeed = new Vector2(3, 4);
    private Rigidbody2D body;
    private Vector2 currentSpeed;
    private AudioSource[] sources = new AudioSource[1];
    ///////////////////////////////////////////////////////////////////////////
    /// 
    /// TODO: Declare an array of AudioSource objects as per the design
    /// 
    ///////////////////////////////////////////////////////////////////////////


    void OnCollisionEnter2D(Collision2D collision)
    {
        sources[0].Play();  // play first sound

        // then bounce off the collision normal
        body.velocity = Vector2.Reflect(currentSpeed, collision.contacts[0].normal);
    }

    // Use this for initialization
    void Start()
    {
        ///////////////////////////////////////////////////////////////////////////
        /// 
        /// TODO: Use the 'GetComponents' function to retrieve an array of audio
        /// sources and store it in the sources array you declared
        /// 
        ///////////////////////////////////////////////////////////////////////////

        // Use the 'GetComponent' function to cache the reference to the rigid body.
        body = GetComponent<Rigidbody2D>();

        Spawn();
    }

    // Update is called once per frame
    void Update()
    {
        currentSpeed = GetComponent<Rigidbody2D>().velocity;    // store speed for collision response
        if (transform.position.y < -5f)
        {
            ///////////////////////////////////////////////////////////////////////////
            /// 
            /// TODO: Play the sound clip from the second audio source.
            /// 
            ///////////////////////////////////////////////////////////////////////////
            sources[1].Play(); // play second sound

            FindObjectOfType<GameManager>().lives -= 1; // tell GM to lose a life
            Spawn();    // respawn at start point
        }

        // make sure ball isnt going too much of an angle, too slow, or too fast.
        if (Mathf.Abs(body.velocity.y) < 2) body.velocity = new Vector2(body.velocity.x, 2 * Mathf.Sign(body.velocity.y));
        if (Mathf.Abs(body.velocity.x) < 2) body.velocity = new Vector2(2 * Mathf.Sign(body.velocity.x), body.velocity.y);
        if (body.velocity.magnitude < 3) body.velocity = body.velocity.normalized * 3;
        if (body.velocity.magnitude > 10) body.velocity = body.velocity.normalized * 10;
    }

    private void Spawn()
    {
        body.velocity = baseSpeed;          // initial velocity
        if (Random.Range(1, 3) == 1)
            body.velocity = new Vector2(baseSpeed.x * -1, baseSpeed.y);    // randomly select start direction
        transform.position = spawnPoint;    // initial location
    }
}