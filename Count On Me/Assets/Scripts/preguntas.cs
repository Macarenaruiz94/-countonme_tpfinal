using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class preguntas : MonoBehaviour
{
    public GameObject textObject;
    void Start()
    {
        textObject.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            textObject.SetActive(true);
        }
    }
}
