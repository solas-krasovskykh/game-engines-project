using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CollisionManager : MonoBehaviour
{
    [Header("Main")]
    public bool checkTag = false;
    public string checkTagName = "obstacle";

    public UnityEvent ObstacleCollisionEvent;
    
    private void OnCollisionEnter(Collision collision)
    {
        if (checkTag && collision.collider.tag != checkTagName) return;
        
        ObstacleCollisionEvent.Invoke();
    }

    private void OnCollisionStay(Collision collision)
    {
        
    }

    private void OnCollisionExit(Collision collision)
    {
        
    }
}
