using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;

public class CameraController : NetworkBehaviour
{
    float rotationX, rotationY;
    public float mouseSensitivity = 90f;
    public Camera cam;
    public Transform player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!isLocalPlayer)
        {
            return;
        }
        float mouseY = Input.GetAxis("Mouse Y") * Time.deltaTime * mouseSensitivity;
        float mouseX = Input.GetAxis("Mouse X") * Time.deltaTime * mouseSensitivity;
        rotationX -= mouseY;
        rotationX = Mathf.Clamp(rotationX, -90f, 90f);
        cam.transform.localEulerAngles = new Vector3(rotationX, 0f, 0f);
        player.Rotate(Vector3.up * mouseX);
    }
}
