using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharactersMenu : HandlingColor
{
    public Camera gameCamera;
    public GameObject marker;

    private CharactersMenu character;
    public Color color { get; private set; }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            HandleSelection();
        }
        markerHandling();
    }
    

    private void HandleSelection()
    {
        var ray = gameCamera.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
            var sphere = hit.collider.GetComponentInParent<CharactersMenu>();
            character = sphere;
            if (hit.collider.GetComponentInParent<CharactersMenu>())
            {
                color = character.GetComponentInChildren<Renderer>().material.color;
                ColorSelection(color);
            }  
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
