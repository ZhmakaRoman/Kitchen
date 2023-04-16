using System;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ObjectsInteractionTask5 : MonoBehaviour
{
    // TODO: Подпишитесь на событие ItemSpawned класса Shelf
    // TODO: Если на полке станет более трех предметов - вызовите у объекта Shelf метод Fall
    // TODO: Логика должна работать для обоих полок сцены
    [SerializeField]
    private List<Shelf> _shelfPrefab;
    

     private void Start()
     {
         foreach (Shelf prefab in _shelfPrefab)
         {
             prefab.ItemSpawned += TestOfStrength;
         }
     }
     private void OnDestroy()
     {
         foreach (Shelf prefab in _shelfPrefab)
         {
             prefab.ItemSpawned -= TestOfStrength;
         }
         
     }
   
     
     private void TestOfStrength()
     {

         foreach (Shelf prefab in _shelfPrefab)
         {
             if (prefab.ItemsCount > 2 )
             {
                 prefab.Fall();
             }
         }
        
     }
}