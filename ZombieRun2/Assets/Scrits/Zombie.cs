
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Zombie : MonoBehaviour
{
    private void OnMouseDown()
    {
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
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name == "toca y pierde")
        {
            SceneManager.LoadScene("Game Over");
        }
    }
}
