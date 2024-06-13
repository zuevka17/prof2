using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrderResponse : MonoBehaviour, IUnitOrderInterface
{
    public Vector3 TakeOrder()
    {
        Vector3 vector3 = Vector3.zero;
        if (Input.GetMouseButton(1))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            Physics.Raycast(ray, out hit, 100);
            vector3 = hit.point;
        }
        return vector3;
    }
}
