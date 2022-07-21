using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class botonPregunta : MonoBehaviour
{
    public GameObject text;
    public Color wantedColor;
    public Button boton;
    public void CambiarColor()
    {
        StartCoroutine("WaitForSec");
        
        ColorBlock cb = boton.colors;
        cb.normalColor = wantedColor;
        cb.highlightedColor = wantedColor;
        cb.pressedColor = wantedColor;
        cb.selectedColor = wantedColor;
        //cb.disabledColor = wantedColor;
        boton.colors = cb;
    }

    IEnumerator WaitForSec()
    {
        yield return new WaitForSeconds(3);
        Destroy(text);
    }
}
