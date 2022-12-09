using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{

    public Transform playerBody;
   public float Sensibility = 100;
    public Vector2 sens;
    //Rotation in X
    public float xRotation;
    public float yRotation;
    //registers the diference between the camera position and the player's position
    private Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
        //The cursor will appear in the center of the screen
        Cursor.lockState = CursorLockMode.Locked;
        //diference between the camera position and the player's position
        offset = transform.position - playerBody.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        //update de position of the camera
        transform.position = playerBody.transform.position + offset;
        //mouse movement in X (pixels)
        float mouseX = Input.GetAxisRaw("Mouse X") * Sensibility * Time.deltaTime;
        //mouse movement in Y (pixels)
        float mouseY= Input.GetAxisRaw("Mouse Y") * Sensibility * Time.deltaTime;

        yRotation += mouseX;
        xRotation -= mouseY;
        //limits of the rotation
        xRotation = Mathf.Clamp(xRotation, -80, 80);

        //the camera it's a son. We use localRotation
        transform.localRotation = Quaternion.Euler(xRotation, 0, 0);
        
        //We will rotate the position of the player in axis Y and multiply it with the movement of the mouse in X
        playerBody.Rotate(Vector3.up * mouseX);
        
    }
}
