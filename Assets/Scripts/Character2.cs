using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//INHERITANCE
public class Character2 : Character
{
    private Vector3 movement;

    private void Start()
    {
        movement = Vector3.back;
    }

    // POLYMORPHISM
    void Update()
    {
        ChangeColor();
        move(movement);
    }

}
