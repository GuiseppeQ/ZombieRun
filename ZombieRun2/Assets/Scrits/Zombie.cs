
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Zombie : MonoBehaviour
{
    public Animator sangre;
    public float cantidadCorazones;

    private void Start()
    {
        sangre = GetComponent<Animator>();
    }
    private void OnMouseDown()
    {
        GetComponent<AudioSource>().Play();
        sangre.SetTrigger("sangreeee");
        GetComponent<caminar>().speedMovement = 0;        
        GetComponent<CaminarEnX>().velocidadenX = 0;
        
        StartCoroutine(Muerte());
    }
    IEnumerator Muerte()
    {
        yield return new WaitForSeconds(1f);
        Destroy(gameObject);

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (GetComponent<CaminarEnX>().direccionX >= 0)
        {
            GetComponent<CaminarEnX>().direccionX = -1;
        }
        else
        {
            GetComponent<CaminarEnX>().direccionX = 1;
        }

    }
}
