using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class botonIncorrecto : MonoBehaviour
{
    public Color wantedColor;
    public Button boton;
    public void CambiarColor()
    {
        ColorBlock cb = boton.colors;
        cb.normalColor = wantedColor;
        cb.highlightedColor = wantedColor;
        cb.pressedColor = wantedColor;
        cb.selectedColor = wantedColor;
        boton.colors = cb;
    }
}
