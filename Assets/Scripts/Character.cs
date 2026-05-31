using UnityEngine;
using UnityEngine.InputSystem;

public class Character : MonoBehaviour
{
    [SerializeField]
    private float speed;
    [SerializeField]
    private float camSense;
    private PlayerInput playerInput;
    private Rigidbody rb;
    private Transform cam;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerInput = GetComponent<PlayerInput>();
        rb = GetComponent<Rigidbody>();
        cam = Camera.main.transform;
    }
    //AÑADIR SONIDO DE PASOS
    // Update is called once per frame
    void Update()
    {
        Vector2 inputDirection = playerInput.actions["Move"].ReadValue<Vector2>();
        Vector2 inputLook = playerInput.actions["Look"].ReadValue<Vector2>();
        Vector3 move = ((transform.forward * inputDirection.y) + (transform.right * inputDirection.x)) * speed;
        
        rb.linearVelocity = new Vector3(move.x, rb.linearVelocity.y, move.z);
        cam.localEulerAngles += (new Vector3(inputLook.y * camSense * -1, 0, 0)) * Time.deltaTime;
        transform.localEulerAngles += (new Vector3(0, inputLook.x * camSense, 0)) * Time.deltaTime;
    }
}
