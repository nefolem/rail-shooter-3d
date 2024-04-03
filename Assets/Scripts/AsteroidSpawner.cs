using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidSpawner : MonoBehaviour
{
    [SerializeField] GameObject asteroid;
    [SerializeField] float spawnDelay = 2f;
    float timer = 0;
    bool isSpawning;

    Vector3 range;
    Vector3 size;    

    // Start is called before the first frame update
    void Start()
    {
        range = transform.position;
        size = transform.localScale;
        isSpawning = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (isSpawning)
        {
            timer += Time.deltaTime;
            if (timer > spawnDelay)
            {
                SpawnAsteroid();
            }
        }
       
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            isSpawning = true;
        }
    }

    private void SpawnAsteroid()
    {
        float xPos = Random.Range(range.x - size.x / 2, range.x + size.x / 2);
        float zPos = Random.Range(range.z - size.z / 2, range.z + size.z / 2);
        Vector3 asteroidPos = new Vector3(xPos, transform.position.y, zPos);
        Instantiate(asteroid, asteroidPos, Quaternion.identity);
        timer = 0;
    }
}
