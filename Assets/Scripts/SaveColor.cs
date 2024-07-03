using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveColor : MonoBehaviour
{
    //ENCAPSULATION
    public static SaveColor Instance { get; private set; }

    public Color characterColor;

    private void Awake()
    {
        if(Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

}
