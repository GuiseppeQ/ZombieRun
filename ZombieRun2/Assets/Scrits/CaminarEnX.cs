using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaminarEnX : MonoBehaviour
{
    public float velocidadenX;
    public int direccionX;

    private void Start()
    {
     direccionX = 1;   
    }

    private void Update()
    {
        

        transform.Translate(new Vector3(direccionX,0,0)* Time.deltaTime * velocidadenX);
    }
    
}
