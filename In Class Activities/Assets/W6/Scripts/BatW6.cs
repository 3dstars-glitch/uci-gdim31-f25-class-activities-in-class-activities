using System;
using UnityEngine;

// Write the BatW6 class here.
public class BatW6 : MonoBehaviour
{
    
    [SerializeField] private Transform _playerTransform;
    [SerializeField] private float _BatSpeed;
    private Boolean Chase;

    public void enableChase(Transform player)
    {
        Chase=true;
        _playerTransform=player;
    }
    public void disableChase()
    {
        Chase=false;
    }
    public void Update()
    {
        if (Chase==true)
        {
            transform.position=Vector2.MoveTowards(transform.position,_playerTransform.position,_BatSpeed*Time.deltaTime);
            Debug.Log(" chase");
        }
    }
}
