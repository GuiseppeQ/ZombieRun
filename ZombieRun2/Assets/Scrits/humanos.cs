using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class humanos : MonoBehaviour
{
    

    private void OnMouseDown()
    {
        Destroy(gameObject);

        SceneManager.LoadScene("Game Over");
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
