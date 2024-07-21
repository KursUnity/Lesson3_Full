using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorSwitch : MonoBehaviour
{
    private Renderer objectRenderer;


    void Start()
    {
        objectRenderer = GetComponent<Renderer>(); // Получаем компонент Renderer, который находится там же, где и скрипт
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1)) // Если нажали на цифру 1 на клавиатуре (НЕ Num1)
        {
            ChangeColor(1);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2)) // Если нажата цифра 2
        {
            ChangeColor(2);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3)) // Если нажата 3
        {
            ChangeColor(3);
        }
        else if (Input.GetKeyDown(KeyCode.Space)) // Если нажали на пробел
        {
            ChangeColor(12);
        }
    }

    void ChangeColor(int colorIndex)
    {
        switch (colorIndex)
        {
            case 1: //Если передана в метод цифра 1
                objectRenderer.material.color = Color.red;
                break; // Остановить задачу (дальше не продолжать)
            case 2:
                objectRenderer.material.color = Color.green;
                break;
            case 3:
                objectRenderer.material.color = Color.blue;
                break;
            default: // Выполняется если не нашлось подходящей цифры
                objectRenderer.material.color = Color.white; // white - это стандартный цвет объекта. Если он изначально был синим, то станет синим (оригинальный цвет)
                break;
        }
    }
}
