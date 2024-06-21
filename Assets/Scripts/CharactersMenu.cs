using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class CharactersMenu : MonoBehaviour
{
    private GameObject[] charactersList = new GameObject[3];

    private void Start()
    {
        CharacterProperties();
    }

    private void CharacterProperties()
    {
        int i = 0;
        foreach (Transform child in transform)
        {
            if (child.tag == "Character")
            {
                charactersList[i] = child.gameObject;
                i++;
            }
        }
    }

    public void Back()
    {
        SceneManager.LoadScene(0);
    }

    public void Menu()
    {
        SceneManager.LoadScene(0);
    }
}
