using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    // Infection
    public int minInfection = 0;
    public int currentInfection = 0;
    public int maxInfection = 50;

    public InfectoMeter infectoMeter;
    public Transform covid;
    public Transform patient;

    // Movement
    public float playerSpeed = 2.0f;
    private float currentSpeed = 0.0f;
    public List<KeyCode> upButton;
    public List<KeyCode> downButton;
    public List<KeyCode> leftButton;
    public List<KeyCode> rightButton;
    private Vector3 lastMovement = new Vector3();


    // Laser
    [SerializeField] Transform mask;
    [SerializeField] Transform vaccine;
    public float projDistance = .2f;
    public float timeBetweenFires = .3f;
    private float timeTilNextFire = 0.0f;
    public List<KeyCode> maskButton;
    public List<KeyCode> vaccineButton;

    private void Start()
    {
        currentInfection = minInfection;
        infectoMeter.slider.value = minInfection;
    }


    // Update is called once per frame
    void Update()
    {
        Look();
        Move();
        
        foreach (KeyCode element in maskButton)
        {
            if (Input.GetKey(element) && timeTilNextFire < 0)
            {
                timeTilNextFire = timeBetweenFires;
                ShootLaser(mask);
                break;
            }
        }
        foreach (KeyCode element in vaccineButton)
        {
            if (Input.GetKey(element) && timeTilNextFire < 0)
            {
                timeTilNextFire = timeBetweenFires;
                ShootLaser(vaccine);
                break;
            }
        }
        timeTilNextFire -= Time.deltaTime;
    }

    private void ShootLaser(Transform projType)
    {
        
        float posX = this.transform.position.x +
        (Mathf.Cos((transform.localEulerAngles.z - 90) *
        Mathf.Deg2Rad) * -projDistance);
        float posY = this.transform.position.y + (Mathf.Sin((transform.localEulerAngles.z - 90) * Mathf.Deg2Rad) *-projDistance);

        Instantiate(projType, new Vector3(posX, posY, 0), this.transform.rotation);
    }

    private void Look()
    {
        Vector3 worldPos = Input.mousePosition;
        worldPos = Camera.main.ScreenToWorldPoint(worldPos);
        
        float dx = this.transform.position.x - worldPos.x;
        float dy = this.transform.position.y - worldPos.y;

        
        float angle = Mathf.Atan2(dy, dx) * Mathf.Rad2Deg;
        
        Quaternion rot = Quaternion.Euler(new Vector3(0, 0, angle +
        90));
        
        this.transform.rotation = rot;
    }

    private void Move()
    {
        
        Vector3 movement = new Vector3();
        
        movement += MoveIfPressed(upButton, Vector3.up);
        movement += MoveIfPressed(downButton, Vector3.down);
        movement += MoveIfPressed(leftButton, Vector3.left);
        movement += MoveIfPressed(rightButton, Vector3.right);

        movement.Normalize();
        
        if (movement.magnitude > 0)
        {
            
            currentSpeed = playerSpeed;
            this.transform.Translate(movement * Time.deltaTime *
            playerSpeed, Space.World);
            lastMovement = movement;
        }
        else
        {
            
            this.transform.Translate(lastMovement * Time.deltaTime *
            currentSpeed, Space.World);
           
            currentSpeed *= .9f;
        }
    }


    Vector3 MoveIfPressed(List<KeyCode> keyList, Vector3 Movement)
    {
        foreach (KeyCode element in keyList)
        {
            if (Input.GetKey(element))
            {
                return Movement;
            }
        }

        return Vector3.zero;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Infection rate goes up when colliding with enemy
        if (collision.gameObject.name.Contains("Covid") || collision.gameObject.name.Contains("Patient"))
        {
            currentInfection++;
            infectoMeter.slider.value = currentInfection;
            if(currentInfection >= 50)
            {
                SceneManager.LoadScene(4);
            }
        }
    }
}
