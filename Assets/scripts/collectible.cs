using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class collectible : MonoBehaviour
{
    public UnityEvent plusOneCoinEvent;
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.tag == "Player")
        {
            plusOneCoinEvent.Invoke();
        }
    }
}
