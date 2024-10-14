using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    public float movementSpeed = 5.0f;
    public float jumpPower = 10f;
    Vector3 movementDirectionW = Vector3.forward;
    Vector3 movementDirectionS = Vector3.back;
    Vector3 movementDirectionA = Vector3.left;
    Vector3 movementDirectionD = Vector3.right;
    public KeyCode KeyF = KeyCode.None;
    public KeyCode KeyB = KeyCode.None;
    public KeyCode KeyL = KeyCode.None;
    public KeyCode KeyR = KeyCode.None;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      bool isKeyPressedF = Input.GetKey(KeyF);
        if (isKeyPressedF)
        {
            transform.position = transform.position + new Vector3(0, 0, 1) * Time.deltaTime * movementSpeed;
        }

        bool isKeyPressedB = Input.GetKey(KeyB);
        if (isKeyPressedB)
        {
            transform.position = transform.position + new Vector3(0, 0, -1) * Time.deltaTime * movementSpeed;
        }

        bool isKeyPressedL = Input.GetKey(KeyL);
        if (isKeyPressedL)
        {
            transform.position = transform.position + new Vector3(-1, 0, 0) * Time.deltaTime * movementSpeed;
        }

        bool isKeyPressedR = Input.GetKey(KeyR);
        if (isKeyPressedR)
        {
            transform.position = transform.position + new Vector3(1, 0, 0) * Time.deltaTime * movementSpeed;
        }

    }
}
