using System;
using UnityEngine;
using UnityEngine.AI;

// Write your DeerW5 class in here :)
// Hint: if you don't remember what a class is supposed to look like,
//      maybe check out CatW5...
// If you copied the class declaration from CatW5, you'd only need to change one thing...
public class DeerW5 : MonoBehaviour
{
    [SerializeField] private Transform itemHoming;
    
    [SerializeField] private NavMeshAgent agent;


    private void Start()
    {
        agent.GetComponent<NavMeshAgent>();  
        if (itemHoming != null)
        {
            agent.SetDestination(itemHoming.position);
        }
    }
    private void Update()
    {
        
    }
}