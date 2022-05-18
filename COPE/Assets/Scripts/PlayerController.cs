using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // cope
    // brennan's script
    // will add movement eventually

    float horizontalInput;
    float verticalInput;

    float mouseSensitivity;

    float speed = 20f;

    public Transform playerBody;
    public Transform playerCam;

    public CharacterController characterController;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxisRaw("Horizontal");
        verticalInput = Input.GetAxisRaw("Vertical");

        Vector3 moveHorizontal = transform.right * horizontalInput;
        Vector3 moveVertical = transform.forward * verticalInput;

        characterController.transform.Translate((moveVertical + moveHorizontal) * speed * Time.deltaTime);
    }
}
