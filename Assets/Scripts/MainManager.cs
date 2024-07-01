using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEditor;
using UnityEngine;

public class MainManager : MonoBehaviour
{
    public static MainManager Instance;

    public Color characterColor;
    public string colorName;

    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }

    public void ChangeCharacter()
    {
        SceneManager.LoadScene(2);
    }

    private void Awake()
    {
        if(Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }
}
