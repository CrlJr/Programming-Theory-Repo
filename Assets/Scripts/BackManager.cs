using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BackManager : CharactersMenu
{
    private void Start()
    {
        ColorSelection(gameObject);
    }
}
