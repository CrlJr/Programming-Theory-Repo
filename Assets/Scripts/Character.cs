using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : BackManager
{
    public GameObject character;

    private void Start()
    {
        ColorSelection(character);
    }
}
