using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEditor;
using UnityEngine;

public class MenuManager : MonoBehaviour
{
    public static MenuManager Instance;

    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }

    public void ChangeCharacter()
    {
        SceneManager.LoadScene(2);
    }
}
