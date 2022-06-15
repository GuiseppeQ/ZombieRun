using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo : MonoBehaviour
{
    public Vector3 direccion;
    public float speedMovement;

    void Start()
    {
        direccion.y = -1;

        transform.Translate(direccion);

        Debug.Log("hsdakjds");
    }

    
    void Update()
    {
        
    }
}
