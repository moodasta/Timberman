using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField] private Button playButton;

    void Awake()
    {
        playButton.onClick.AddListener(GoToGameScene);
       
    }

    private void GoToGameScene()
    {
        SceneManager.LoadScene("Game");
    }

    
       
    
}
