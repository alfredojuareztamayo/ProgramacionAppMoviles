using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraAndFPC : MonoBehaviour
{

   // public Camara camara;
   [Header("Camara")]
    public float horizontalSpeed;
    public float verticalSpeed;
    private new Transform camera;
    public Vector2 sensibility;
    public float mouseHorizontal = 3.0f;
    float h_mouse;

   [Header("Character Options")]
    public float walkSpeed = 6.0f;
    public float runSpeed = 10.0f;
    public float jumpSpeed = 8.0f;
    public float gravity = 20.0f;
    CharacterController characterController;

      private Vector3 move = Vector3.zero;

    // Start is called before the first frame update
    void Start()
    {
        characterController = GetComponent<CharacterController>();
        camera = transform.Find("Camera");
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
      
        MoveCharacter();
        CamaraController();
    }

    public void MoveCharacter()
    {
        if (characterController.isGrounded)
        {
            move = new Vector3(Input.GetAxis("Horizontal"), 0.0f, Input.GetAxis("Vertical"));
            if (Input.GetKey(KeyCode.LeftShift))
            {
                move = transform.TransformDirection(move) * runSpeed;
            }
            else
            {
                move = transform.TransformDirection(move) * walkSpeed;
            }

            if (Input.GetKey(KeyCode.Space))
            {
                move.y = jumpSpeed;
            }


        }
        move.y -= gravity * Time.deltaTime;
        characterController.Move(move * Time.deltaTime);
 
    }

    public void CamaraController()
    {
     //   h_mouse = mouseHorizontal * Input.GetAxis("Mouse X");
        float h = Input.GetAxis("Mouse X");
        float v = Input.GetAxis("Mouse Y");
        if (h != 0)
        {
            transform.Rotate(h * sensibility.x * Vector3.up);
        }
        if (v != 0)
        {
            float angle = (camera.localEulerAngles.x - v * sensibility.y + 360) % 360;
            if (angle > 180)
            {
                angle -= 360;
            }
            angle = Mathf.Clamp(angle, -20  , 20);
            camera.localEulerAngles = Vector3.right * angle;
        }
    }
}
