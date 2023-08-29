using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuHandler : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private GameObject landingUI;
    [SerializeField] private GameObject InstructionUI;

    void Awake()
    {
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

    public void ActivateLanding()
    {
        landingUI.SetActive(true);
        InstructionUI.SetActive(false);
    }
}
