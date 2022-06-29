using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class corazones : MonoBehaviour
{
    public float cantidadCorazones = 3f;
    public GameObject[] hearts; 
    private void OnTriggerEnter2D(Collider2D collision)
    {
       
        if (collision.tag == "Zombie")
        {
            foreach (GameObject item in hearts)
            {
                if (item.activeInHierarchy == true)
                {
                    item.SetActive(false);
                    break;
                }

            }
            cantidadCorazones -= 1;
        }
    }
    public void Update()
    {
        if (cantidadCorazones <=0)
        {
            SceneManager.LoadScene("Game Over");
        }
    }
}
