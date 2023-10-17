using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObstacle : MonoBehaviour
{

    
    public List<GameObject> obstacleList; 
    public float maxX;
    public float maxY;
    public float minX;
    public float minY;
    public float timeBetweenSpawn;
    private float spawnTime;
    public Score scoreScript;



    private void Start()
    {
        
    }


    // Update is called once per frame
    void Update()
    {
      
        if (Time.time > spawnTime)
        {
            // space
            if(((int)scoreScript.score) <= 30)
            {
                SpawnForSpace();
                spawnTime = Time.time + timeBetweenSpawn;
            }

            // sky
            else if (((int)scoreScript.score) > 40 && ((int)scoreScript.score) <= 70)
            {
                SpawnForSky();
                spawnTime = Time.time + timeBetweenSpawn;
            }

            // soil
            else if (((int)scoreScript.score) > 80 && ((int)scoreScript.score) <= 110)
            {
                SpawnForSoil();
                spawnTime = Time.time + timeBetweenSpawn;
            }

            // undersea
            else if (((int)scoreScript.score) > 120 && ((int)scoreScript.score) <= 150)
            {
                SpawnForUndersea();
                spawnTime = Time.time + timeBetweenSpawn;
            }
            if (((int)scoreScript.score) == 158)
            {
                SpawnForAtlantis();
                spawnTime = Time.time + timeBetweenSpawn;
            }


        }
    }

    private void SpawnForAtlantis()
    {
        

        Instantiate(obstacleList[5], transform.position + new Vector3(0, 0, 0), transform.rotation);
    }


    private void SpawnForSpace()
    {
        float randomX = Random.Range(minX, maxX);
        float randomY = Random.Range(minY, maxY);
        int randomCreate = Random.Range(0, 2);
        if(randomCreate == 1)
        {
            Instantiate(obstacleList[0], transform.position + new Vector3(randomX, randomY, 0), transform.rotation);
        }
        else
        {
            Instantiate(obstacleList[1], transform.position + new Vector3(randomX, randomY, 0), transform.rotation);
        }
    }

    private void SpawnForSky()
    {
        float randomX = Random.Range(minX, maxX);
        float randomY = Random.Range(minY, maxY);        
        Instantiate(obstacleList[2], transform.position + new Vector3(randomX, randomY, 0), transform.rotation);
    }

    private void SpawnForSoil()
    {
        float randomX = Random.Range(minX, maxX);
        float randomY = Random.Range(minY, maxY);
        Instantiate(obstacleList[3], transform.position + new Vector3(randomX, randomY, 0), transform.rotation);
    }

    private void SpawnForUndersea()
    {
        float randomX = Random.Range(minX, maxX);
        float randomY = Random.Range(minY, maxY);
        Instantiate(obstacleList[4], transform.position + new Vector3(randomX, randomY, 0), transform.rotation);
    }



    private void Spawn()
    {
        float randomX = Random.Range(minX, maxX);
        float randomY = Random.Range(minY, maxY);


        Instantiate(obstacleList[0], transform.position + new Vector3(randomX, randomY, 0), transform.rotation);



    }





}
