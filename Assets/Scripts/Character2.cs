using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character2 : Character
{
    private Vector3 movement;

    private void Start()
    {
        movement = Vector3.back;
    }

    // Update is called once per frame
    void Update()
    {
        ChangeColor();
        move(movement);
    }

}
