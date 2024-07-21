using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationSwitch : MonoBehaviour
{
    private Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>(); // Получаем компонент Animator с объекта на котором находится данный скрипт..
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            ChangeAnimation(1); // Вызов кейса под номером 1
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            ChangeAnimation(2); // Вызов кейса под номером 2
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            ChangeAnimation(3); // Вызов кейса под номером 3
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
