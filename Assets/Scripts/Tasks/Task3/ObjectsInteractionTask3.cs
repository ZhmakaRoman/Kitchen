using System;
using UnityEngine;

public class ObjectsInteractionTask3 : MonoBehaviour
{
    // TODO: Получите доступ ко всем объектам сцены со скриптом Lamp
    // TODO: При нажатии на кнопку 2 на клавиатуре вызывайте у всех полученных объектов метод Interact


    private void Update()
    {
        var Lamps = FindObjectsOfType<Lamp>();
        foreach (var lamp in Lamps)
        {
            var lamps = lamp.GetComponents<Lamp>();
            
            foreach (Lamp la in lamps)
            {
                if (Input.GetKeyDown(KeyCode.Alpha2))
                {
                    lamp.Interact();
                }
                
            }
        }
        
    }
    
}