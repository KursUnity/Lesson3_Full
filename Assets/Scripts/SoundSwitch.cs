using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundSwitch : MonoBehaviour
{
    public AudioClip sound1; // ���������� �����
    public AudioClip sound2;
    public AudioClip sound3;

    private AudioSource audioSource; // ���������� � ������� ����� �������������� �����
    
    void Start()
    {
        audioSource = GetComponent<AudioSource>(); // �������� ������ ������ � ������� �� ������� ��������� ������ ������
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            PlaySound(1);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            PlaySound(2);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            PlaySound(3);
        }
    }

    void PlaySound(int soundIndex)
    {
        switch (soundIndex)
        {
            case 1:
                audioSource.clip = sound1;
                break;
            case 2:
                audioSource.clip = sound2;
                break;
            case 3:
                audioSource.clip = sound3;
                break;
        }

        audioSource.Play();
    }
}
