using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HandlingColor : MonoBehaviour
{
    private Color red;
    private Color green;
    private Color blue;
    private Color characterColorChange;

    private void Awake()
    {
        HandleColor();
    }

    //ABSTRACTION
    private void HandleColor()
    {
        red = Color.red;
        green = Color.green;
        blue = Color.blue;

        int i = 1;
        foreach (GameObject gameobj in GameObject.FindObjectsOfType<GameObject>())
        {
            if (gameobj.name.Contains("Character "))
            {
                switch (i)
                {
                    case 1:
                        gameobj.GetComponent<Renderer>().material.color = red;
                        break;
                    case 2:
                        gameobj.GetComponent<Renderer>().material.color = green;
                        break;
                    case 3:
                        gameobj.GetComponent<Renderer>().material.color = blue;
                        break;

                }
                i++;
            }
        }
    }

    //ABSTRACTION
    public void ColorSelection(Color color)
    {
        if (color == red)
        {
            characterColorChange = red;
        }
        else if (color == green)
        {
            characterColorChange = green;
        }
        else if (color == blue)
        {
            characterColorChange = blue;
        }
        SaveColor.Instance.characterColor = characterColorChange;
    }

}
