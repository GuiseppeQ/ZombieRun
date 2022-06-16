using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class caminar : MonoBehaviour
{
    public Vector3 direccion;
    public float speedMovement;
    
    void Update()
    {
        direccion.y = -1;

        transform.Translate(speedMovement * direccion * Time.deltaTime);
    }
}
