using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnZom : MonoBehaviour
{
    public GameObject Prefab;
    public float TiempoDeCreacion = 2f, rangoDeCreacion = 2f; 
    private float cont;

     void Start()
     {
        InvokeRepeating("Creando", 0.0f, TiempoDeCreacion);  
     }

    void Update()
    {
        if (cont >= 2)
        {
            GameObject GO = Instantiate(Prefab, transform.position, transform.rotation);
            cont = 0;
        }

        cont += Time.deltaTime;
    }
     
    public void Creando()
    {
        Vector3 spawnPosition = new Vector3(0, 0, 0);
        spawnPosition = this.transform.position + Random.onUnitSphere * rangoDeCreacion;
        spawnPosition = new Vector3(spawnPosition.x, spawnPosition.y, 0);

        GameObject prefab = Instantiate(Prefab, spawnPosition, Quaternion.identity);

    }
    
}
