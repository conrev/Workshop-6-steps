using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreClient : MonoBehaviour
{
    private GameManager _gameManager;

    // Start is called before the first frame update
    void Start()
    {

        _gameManager = GameObject.FindWithTag(GameManager.Tag).GetComponent<GameManager>();
    }

    public void AddScore(int value)
    {
        _gameManager.registerScoreChange(value);
    }
}
