using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnZom : MonoBehaviour
{
    public GameObject prefab;
    
    private float cont;
    void Update()
    {
        if (cont >= 2)
        {
            GameObject GO = Instantiate(prefab, transform.position, transform.rotation);
            cont = 0;
        }

        cont += Time.deltaTime;
    }
}
