using UnityEngine;
using UnityEngine.UI;


public class PlayerMovement : MonoBehaviour
{
    [SerializeField] GameObject player;
    [SerializeField] GameObject playerCamera;

    [SerializeField] float sensitivity;
    float rotationX;
    float rotationY;
    float speed;

    Animator anim;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = true;
        speed = 6f;
        anim = player.GetComponent<Animator>();

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rotationX -= Input.GetAxisRaw("Mouse Y") * Time.deltaTime * sensitivity;
        rotationY += Input.GetAxisRaw("Mouse X") * Time.deltaTime * sensitivity;
        rotationX = Mathf.Clamp(rotationX, -90f, 90f);
        player.transform.eulerAngles = new Vector3(0, rotationY, 0);
        playerCamera.transform.eulerAngles = new Vector3(rotationX, rotationY, 0);

        if (Input.GetKey(KeyCode.LeftShift) && !Input.GetKey(KeyCode.LeftControl))
        {
            speed = 7f;
            anim.SetFloat("Speed", 2);
        }
        else if (Input.GetKey(KeyCode.LeftControl) || (Input.GetKey(KeyCode.LeftControl) && Input.GetKey(KeyCode.LeftShift)))
        {
            speed = 2f;
            anim.SetFloat("Movement", 0.5f);
            anim.SetFloat("Speed", 1);

        }
        else if ((Input.GetAxis("Horizontal") != 0 || Input.GetAxis("Vertical") != 0))
        {
            speed = 4f;
            anim.SetFloat("Speed", 1);
            anim.SetFloat("Movement", 1);

        }
        else {
           
            anim.SetFloat("Speed", 0);
        }

        player.transform.Translate(Input.GetAxis("Horizontal") * speed * Time.deltaTime, 0, Input.GetAxis("Vertical") * speed * Time.deltaTime);
    }
}





