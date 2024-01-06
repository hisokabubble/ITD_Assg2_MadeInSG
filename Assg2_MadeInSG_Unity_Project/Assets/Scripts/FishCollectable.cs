using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class FishCollectable : MonoBehaviour
{
    public static event Action OnCollected;
    

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            OnCollected?.Invoke();
            CollectableCount.Score += 5;
            Destroy(gameObject);
            Debug.Log(CollectableCount.Score);
        }
    }

    
}
