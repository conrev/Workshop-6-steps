using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuHandler : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private GameObject landingUI;
    [SerializeField] private GameObject InstructionUI;
    [SerializeField] private TMPro.TMP_Text scoreText;

    private GameManager _gameManager;

    void Awake()
    {
        var gameManagerSearch = GameObject.FindGameObjectWithTag(GameManager.Tag);
        if (gameManagerSearch)
            _gameManager = gameManagerSearch.GetComponent<GameManager>();

        LoadPreviousScore();
        ActivateLanding();
    }

    public void StartGame()
    {
        SceneManager.LoadSceneAsync("MainScene", LoadSceneMode.Single);
    }

    public void ActivateInstructions()
    {
        landingUI.SetActive(false);
        InstructionUI.SetActive(true);
    }

    public void LoadPreviousScore()
    {
        if (_gameManager)
            scoreText.text = "◆" + _gameManager.GameScore;
    }

    public void ActivateLanding()
    {
        landingUI.SetActive(true);
        InstructionUI.SetActive(false);
    }
}
