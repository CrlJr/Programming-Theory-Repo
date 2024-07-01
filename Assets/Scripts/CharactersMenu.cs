using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharactersMenu : MonoBehaviour
{
    public Camera gameCamera;
    public GameObject marker;

    private CharactersMenu character;
    private Color red;
    private Color green;
    private Color blue;
    private string colorName;

    private void Awake()
    {
        HandleColor();
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            HandleSelection();
        }
        markerHandling();
    }

    private void HandleColor()
    {
        red = new Color32(205, 35, 35, 255);
        green = new Color32(65, 210, 35, 255);
        blue = new Color32(35, 125, 255, 255);

        int i = 1;
        foreach(GameObject gameobj in GameObject.FindObjectsOfType<GameObject>())
        {
            if (gameobj.name.Contains("Character "))
            { 
                switch (i){
                    case 1:
                        gameobj.GetComponent<Renderer>().material.color = red;
                        MainManager.Instance.colorName = "red";
                        break;
                    case 2:
                        gameobj.GetComponent<Renderer>().material.color = green;
                        MainManager.Instance.colorName = "green";
                        break;
                    case 3:
                        gameobj.GetComponent<Renderer>().material.color = blue;
                        MainManager.Instance.colorName = "blue";
                        break;

                }
                i++;
            }
        }
    }

    public virtual void ColorSelection(GameObject character)
    {
        if(colorName == "red")
        {
            character.GetComponent<Renderer>().material.color = red;
        }
        else if(colorName == "green")
        {
            character.GetComponent<Renderer>().material.color = green;
        }
        else if (colorName == "blue")
        {
            character.GetComponent<Renderer>().material.color = blue;
        }
    }

    private void HandleSelection()
    {
        var ray = gameCamera.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
            var sphere = hit.collider.GetComponentInParent<CharactersMenu>();
            character = sphere;

            var color = hit.collider.GetComponentInParent<Renderer>().material.color;
            MainManager.Instance.characterColor = color;
        }

    }

    private void markerHandling()
    {
        if(character == null && marker.activeInHierarchy)
        {
            marker.SetActive(false);
            marker.transform.SetParent(null);
        }
        else if (character != null && marker.transform.parent != character.transform)
        {
            marker.SetActive(true);
            marker.transform.SetParent(character.transform, false);
            marker.transform.localPosition = new Vector3(0,1,0);
        }
    }

}
