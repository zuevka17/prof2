using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyAroundBase : MonoBehaviour
{
    public float detectionRadius = 10.0f;
    public LayerMask detectionLayer;

    void Update()
    {
        DetectObjectsInRadius();
    }

    void DetectObjectsInRadius()
    {
        Collider[] hitColliders = Physics.OverlapSphere(transform.position, detectionRadius, detectionLayer);
        foreach(var item in hitColliders)
        {
            Destroy(item.gameObject);
        }    
    }
}
