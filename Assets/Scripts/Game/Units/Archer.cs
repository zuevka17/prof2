using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Archer : MonoBehaviour
{
    [SerializeField] private ArcherModel _model;

    private IUnitOrderInterface _orderResponse;

    private bool isSelected;
    private BoxCollider bc;
    private Rigidbody rb;

    public void Awake()
    {
        _orderResponse = gameObject.GetComponent<IUnitOrderInterface>();

        bc = GetComponent<BoxCollider>();
        rb = GetComponent<Rigidbody>();
    }
    public void Update()
    {
        Vector3 vector = _orderResponse.TakeOrder();
        if(vector == Vector3.zero)
        {
            return;
        }
        rb.MovePosition(vector);
        
    }



}
