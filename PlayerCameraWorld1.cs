using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCameraWorld1 : MonoBehaviour
{
    public float World1MouseSensitivity = 100f;
    public Transform World1PlayerBody;
    float W1xRotation = 0f;


    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * World1MouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * World1MouseSensitivity * Time.deltaTime;
        W1xRotation -= mouseY;
        W1xRotation = Mathf.Clamp(W1xRotation, -90f, 90f);

        transform.localRotation = Quaternion.Euler(W1xRotation, 0f, 0f);
        World1PlayerBody.Rotate(Vector3.up * mouseX);
    
    
    
    }
}
