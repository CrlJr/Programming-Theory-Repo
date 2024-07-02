using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class SelectionMenu : MonoBehaviour
{
    private Color Ccolor = Color.white;

    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }


    public void ChangeCharacter()
    {
        SceneManager.LoadScene(2);
    }


    public void Menu()
    {
        SaveColor.Instance.characterColor = Ccolor;
        SceneManager.LoadScene(0);
    }


    public void Confirm()
    {
        SceneManager.LoadScene(0);
    }

}
