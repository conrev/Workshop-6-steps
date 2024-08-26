using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static string Tag = "GameManager";
    public static string MenuScene = "MenuScene";

    [SerializeField] private UnityEvent<int> OnScoreChanged;

    private int _gameScore;

    public int GameScore
    {
        get
        {
            return this._gameScore;
        }
        private set { }
    }

    void Awake()
    {
        if (GameObject.FindGameObjectsWithTag(Tag).Length > 1)
        {
            Destroy(gameObject);
            return;
        }
        _gameScore = 0;
        registerScoreChange(0);
        DontDestroyOnLoad(this.gameObject);

    }

    public void registerScoreChange(int changes)
    {
        _gameScore += changes;

        OnScoreChanged.Invoke(_gameScore);
    }

    public void GameFinished()
    {
        StartCoroutine(LoadNewScene());
    }

    private IEnumerator LoadNewScene()
    {
        // give a bit of a break before returning
        yield return new WaitForSeconds(2.0f);

        var op = SceneManager.LoadSceneAsync(MenuScene, LoadSceneMode.Single);

    }
}
