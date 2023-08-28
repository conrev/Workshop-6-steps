using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static string Tag = "GameManager";

    [SerializeField] private TMPro.TMP_Text scoreText;
    private int _gameScore;

    void Awake()
    {
        _gameScore = 0;
        registerScoreChange(0);
    }


    public void registerScoreChange(int changes)
    {
        _gameScore += changes;

        scoreText.text = "◆";
        scoreText.text += _gameScore;

    }

}
