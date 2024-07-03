using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//INHERITANCE
public class Character2 : Character
{
    private Vector3 movement;
    private Vector3 rotation;

    private void Start()
    {
        rotation = movement = Vector3.back;
    }

    
    void Update()
    {
        ChangeColor();
        move(movement);
    }

    // POLYMORPHISM
    public override void move(Vector3 movement)
    {
        transform.Rotate(rotation, 5);
        base.move(movement);
    }

}
