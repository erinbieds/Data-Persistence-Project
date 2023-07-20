using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class MenuUIHandler : MonoBehaviour
{
    [SerializeField] Text NameTyped; 


    public void StartNew()
    {
        SceneManager.LoadScene(1);
    }

    public void Update()
    {
        SetPlayerName();
    }

    public void SetPlayerName()
    {
        PlayerDataHandler.Instance.PlayerName = NameTyped.text;
    }

    public void ExitGame()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif
    }



}
