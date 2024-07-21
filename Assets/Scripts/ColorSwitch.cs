using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorSwitch : MonoBehaviour
{
    private Renderer objectRenderer;


    void Start()
    {
        objectRenderer = GetComponent<Renderer>(); // �������� ��������� Renderer, ������� ��������� ��� ��, ��� � ������
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1)) // ���� ������ �� ����� 1 �� ���������� (�� Num1)
        {
            ChangeColor(1);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2)) // ���� ������ ����� 2
        {
            ChangeColor(2);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3)) // ���� ������ 3
        {
            ChangeColor(3);
        }
        else if (Input.GetKeyDown(KeyCode.Space)) // ���� ������ �� ������
        {
            ChangeColor(12);
        }
    }

    void ChangeColor(int colorIndex)
    {
        switch (colorIndex)
        {
            case 1: //���� �������� � ����� ����� 1
                objectRenderer.material.color = Color.red;
                break; // ���������� ������ (������ �� ����������)
            case 2:
                objectRenderer.material.color = Color.green;
                break;
            case 3:
                objectRenderer.material.color = Color.blue;
                break;
            default: // ����������� ���� �� ������� ���������� �����
                objectRenderer.material.color = Color.white; // white - ��� ����������� ���� �������. ���� �� ���������� ��� �����, �� ������ ����� (������������ ����)
                break;
        }
    }
}
