
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie : MonoBehaviour
{

    private void OnMouseDown()
    {
        //gameObject.SetActive(false);
        Destroy(gameObject);
    }
}
