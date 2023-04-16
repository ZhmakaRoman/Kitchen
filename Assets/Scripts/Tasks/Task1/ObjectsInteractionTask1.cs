using System;
using UnityEngine;

public class ObjectsInteractionTask1 : MonoBehaviour
{
   
    // TODO: При нажатии на кнопку 1 на клавиатуре вызывайте у него метод Interact
   

    [SerializeField] 
    private Refrigerator _refrigerator;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            _refrigerator.Interact();
        }
    }
}
      
      


