﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TitleController : MonoBehaviour
{
    public Text highScoreLabel;

    public void Start()
    {
        // ハイスコアを表示
        highScoreLabel.text = "High Score : " + PlayerPrefs.GetInt("HighScore") + "m";
    }

    public void OnStartButtonClicked()
    {
        Application.LoadLevel("Main");
        SceneManager.LoadScene("Main");

        Application.LoadLevelAdditive("Main");
        SceneManager.LoadScene("Main", LoadSceneMode.Additive);
    }
}
