using System;
using JetBrains.Annotations;
using UnityEngine;

public class ObjectsInteractionTask4 : MonoBehaviour
{
    // TODO: Подпишитесь на событие TimerIsUp класса Toaster созданием объекта Waffle в точке WaffleRoot (из папки Prefabs) 

    
    [SerializeField]
    private GameObject _waffle;
    [SerializeField]
   private Transform waffleRoot;
   
  
   private void Start()
   {
       var q = FindObjectOfType<Toaster>();
       q.TimerIsUp += SpawnWaffle;
   }
   
  

   private void SpawnWaffle()
   {
       Instantiate(_waffle, waffleRoot);
   }
}