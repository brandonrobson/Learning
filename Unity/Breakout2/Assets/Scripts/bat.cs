using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bat : MonoBehaviour {
    Vector2 velocity;
    [SerializeField] float speed=8;

	// Update is called once per frame
	void Update () {
        // accelerate smoothly in direction chosen
        velocity.x = Mathf.Lerp(velocity.x, (Input.GetAxis("Horizontal") * speed), 0.5f);

        // find position to move to
        float xPos = transform.position.x + velocity.x * Time.deltaTime;

        // clamp players position so he stays within boundaries
        Vector2 playerPos = new Vector2(Mathf.Clamp(xPos, -5f, 5f), transform.position.y);

        // apply movement
        transform.position = playerPos;
    }
}
