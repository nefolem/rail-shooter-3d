using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{
    private int _score = 0;
    [SerializeField] TMP_Text scoreText;

    private void Start()
    {
        scoreText = gameObject.GetComponentInChildren<TMP_Text>();
        //scoreText = GetComponent<TMP_Text>();
        
    }
    // Update is called once per frame
    void Update()
    {
        scoreText.text = _score.ToString();
    }

    public void AddScorePoints(int scorePoints)
    {
        _score += scorePoints;
    }
}
