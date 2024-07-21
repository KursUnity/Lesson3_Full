using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationSwitch : MonoBehaviour
{
    private Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>(); // �������� ��������� Animator � ������� �� ������� ��������� ������ ������..
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            ChangeAnimation(1); // ����� ����� ��� ������� 1
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            ChangeAnimation(2); // ����� ����� ��� ������� 2
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            ChangeAnimation(3); // ����� ����� ��� ������� 3
        }
    }

    void ChangeAnimation(int animationIndex)
    {
        switch (animationIndex)
        {
            case 1:
                animator.SetTrigger("Anim1");
                break;
            case 2:
                animator.SetTrigger("Anim2");
                break;
            case 3:
                animator.SetTrigger("Anim3");
                break;
        }
    }
}
