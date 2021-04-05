using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{
    [SerializeField] Transform patient;
    [SerializeField] Transform covid;
    [SerializeField] float timeBeforeSpawning = 1.5f;
    [SerializeField] float timeBetweenEnemies = .25f;
    [SerializeField] float timeBeforeWaves = 2f;
    [SerializeField] int winReq = 50;


    int enemiesPerWave = 10;
    private int currentNumberOfEnemies = 0;
    private int enemiesDefeated = 0;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnCovid());
        StartCoroutine(SpawnPatient());
        StartCoroutine(SpawnCovid());

    }

    IEnumerator SpawnCovid()
    {
        yield return new WaitForSeconds(timeBeforeSpawning);
        while (true)
        {
            if (currentNumberOfEnemies <= 0)
            {
                float randDirection;
                float randDistance;

                for (int i = 0; i < enemiesPerWave; i++)
                {
                    randDistance = UnityEngine.Random.Range(10, 25);
                    randDirection = UnityEngine.Random.Range(0, 360);

                    float posX = this.transform.position.x + (Mathf.Cos((randDirection) * Mathf.Deg2Rad) * randDistance);
                    float posY = this.transform.position.y + (Mathf.Sin((randDirection) * Mathf.Deg2Rad) * randDistance);

                    Instantiate(covid, new Vector3(posX, posY, 0), this.transform.rotation);
                    
                    currentNumberOfEnemies++;
                    yield return new WaitForSeconds(timeBetweenEnemies);
                }
            }
            
            yield return new WaitForSeconds(timeBeforeWaves);
        }
    }

    IEnumerator SpawnPatient()
    {
        yield return new WaitForSeconds(timeBeforeSpawning);
        while (true)
        {
            if (currentNumberOfEnemies <= 0)
            {
                float randDirectionP;
                float randDistanceP;

                for (int i = 0; i < enemiesPerWave; i++)
                {
                    randDistanceP = UnityEngine.Random.Range(10, 25);
                    randDirectionP = UnityEngine.Random.Range(0, 360);

                    float posX = this.transform.position.x + (Mathf.Cos((randDirectionP) * Mathf.Deg2Rad) * randDistanceP);
                    float posY = this.transform.position.y + (Mathf.Sin((randDirectionP) * Mathf.Deg2Rad) * randDistanceP);

                    Instantiate(patient, new Vector3(posX, posY, 0), this.transform.rotation);
                    currentNumberOfEnemies++;
                    yield return new WaitForSeconds(timeBetweenEnemies);
                }
            }

            yield return new WaitForSeconds(timeBeforeWaves);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void KilledEnemy()
    {
        currentNumberOfEnemies--;
        enemiesDefeated++;
        if(enemiesDefeated >= winReq)
        {
            SceneManager.LoadScene(3);
        }
    }
}
