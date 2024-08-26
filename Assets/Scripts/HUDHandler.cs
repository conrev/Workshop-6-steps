using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEditor;


public class HUDHandler : MonoBehaviour
{
    [SerializeField] private TMPro.TMP_Text scoreText;

    [SerializeField] private TMPro.TMP_Text statusText;

    [SerializeField] private TMPro.TMP_Text additionalText;

    [SerializeField] private float lerpSpeed = 0.3f;


    void Awake()
    {
        clearStatusText();
    }
    public void updateScore(int newScore)
    {
        // int initialScore = Int32.Parse(this.scoreText.text.Substring(1));
        scoreText.text = "◆ " + Mathf.RoundToInt(newScore);
        //  StartCoroutine(LerpScore(initialScore, newScore));
    }

    public void setStatusText(string mainText)
    {
        this.statusText.text = mainText;
        //this.additionalText.text;
    }

    public void clearStatusText()
    {
        this.statusText.text = "";
        this.additionalText.text = "";
    }

    private IEnumerator LerpScore(int initialScore, int newScore)
    {
        float currentValue = initialScore;
        while (currentValue != newScore)
        {
            currentValue = Mathf.Lerp(currentValue, newScore, lerpSpeed);
            scoreText.text = "◆ " + Mathf.RoundToInt(currentValue);
            yield return new WaitForSeconds(0.03f);
        }
    }



}
