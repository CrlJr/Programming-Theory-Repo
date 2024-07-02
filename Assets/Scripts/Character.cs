using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    private Vector3 movement { get; set; }

    public GameObject character;

    private void Start()
    {
        movement = Vector3.forward;
        ChangeColor();
    }

    public virtual void move(Vector3 movement)
    {
        transform.position = transform.position + movement * Time.deltaTime;
    }

    private void Update()
    {
        move(movement);
    }

    public void ChangeColor()
    {
        character.GetComponent<Renderer>().material.color = SaveColor.Instance.characterColor;
    }

}
