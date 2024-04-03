using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] GameObject enemyExplosion;
    [SerializeField] int scorePoints = 10;
    ScoreController scoreController;

    // Start is called before the first frame update
    void Start()
    {
        scoreController = GameObject.FindObjectOfType<ScoreController>();
    }

    // Update is called once per frame
    void Update()
    {
        //transform.LookAt(FindObjectOfType<PlayerMovement>().transform);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Laser") || other.gameObject.CompareTag("Player"))
        {
            Instantiate(enemyExplosion, transform.position, Quaternion.identity);
            scoreController.AddScorePoints(scorePoints);
            Destroy(gameObject);
        }
    }
}
