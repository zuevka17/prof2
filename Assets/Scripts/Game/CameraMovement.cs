using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    [SerializeField] private float _cameraMovementSpeed;
    [SerializeField] private float _cameraScrollSpeed;

    // Update is called once per frame
    void FixedUpdate()
    {
        if(Input.GetKey(KeyCode.UpArrow))
        {
            Camera.main.transform.position += (Camera.main.transform.forward + Camera.main.transform.up) * Time.fixedDeltaTime * _cameraMovementSpeed;
        }
        if(Input.GetKey(KeyCode.DownArrow))
        {
            Camera.main.transform.position -= (Camera.main.transform.forward + Camera.main.transform.up) * Time.fixedDeltaTime * _cameraMovementSpeed;
        }
        if(Input.GetKey(KeyCode.RightArrow))
        {
            Camera.main.transform.position += (Camera.main.transform.right) * Time.fixedDeltaTime * _cameraMovementSpeed;
        }
        if(Input.GetKey(KeyCode.LeftArrow))
        {
            Camera.main.transform.position -= (Camera.main.transform.right) * Time.fixedDeltaTime * _cameraMovementSpeed;
        }
        if(Input.GetAxis("Mouse ScrollWheel") > 0 && Camera.main.transform.position.y > 305f) 
        {
            Debug.Log(Input.mouseScrollDelta);
            Camera.main.gameObject.transform.position += Camera.main.gameObject.transform.forward * Time.fixedDeltaTime * _cameraScrollSpeed;
        }
        else if(Input.GetAxis("Mouse ScrollWheel") < 0 && Camera.main.transform.position.y < 340f) 
        {
            Debug.Log(Input.mouseScrollDelta);
            Camera.main.gameObject.transform.position -= Camera.main.gameObject.transform.forward * Time.fixedDeltaTime * _cameraScrollSpeed;
        }
    }
}
