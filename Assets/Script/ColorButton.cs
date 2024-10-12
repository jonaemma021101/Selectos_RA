//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorButton : MonoBehaviour
{
    private Button _colorBtn;
    private Image _colorImg;

    private void Awake()
    {
        _colorBtn = GetComponent<Button>();
        _colorImg = GetComponent<Image>();
    }

    private void Start() 
    {
        _colorBtn.onClick.AddListener(ChangeToRandomColor);
    }

    private void ChangeToRandomColor()
    {
        // Genera un color aleatorio más vivo (saturación alta y brillo alto)
        // HSV (Hue, Saturation, Value), aquí lo ajustamos para que la saturación y el brillo sean altos.
        Color randomColor = Random.ColorHSV(0f, 1f,    // Rango de matiz (hue) completo (0 a 1)
                                            0.7f, 1f,  // Saturación alta (0.7 a 1)
                                            0.7f, 1f); // Brillo alto (0.7 a 1)

        // Cambia el color de la imagen del botón
        _colorImg.color = randomColor;

        // Llama a la función ChangeColor del GameManager, pasando el color random
        GameManager.Instance.ChangeColor(randomColor);
    }
}
