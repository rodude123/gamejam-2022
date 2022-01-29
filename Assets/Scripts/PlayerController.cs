using System;
using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerController : MonoBehaviour
{
    public float speed = 10f;
    public Camera mainCam;

    private MasterInputs controls;
    private Rigidbody2D rb;
    private Vector2 move;
    private Transform weapon;

    void Awake()
    {
        controls = new MasterInputs();
        
        controls.Player.Moevement.performed += ctx => move = ctx.ReadValue<Vector2>();
        controls.Player.Moevement.canceled += ctx => move = Vector2.zero;
        
    }
    
    void Start()
    {
       rb = GetComponent<Rigidbody2D>(); 
       weapon = transform.GetChild(0);
    }
    
    void OnEnable()
    {
        controls.Enable();
    }
    
    void OnDisable()
    {
        controls.Disable();
    }

    private void Update()
    {
        Vector3 mousePosition = Mouse.current.position.ReadValue();
        mousePosition = mainCam.ScreenToWorldPoint(mousePosition);
        mousePosition.z = mainCam.nearClipPlane;
        Vector3 direction = (mousePosition - transform.position).normalized;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        weapon.rotation = Quaternion.Euler(0, 0, angle);
    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + move * speed * Time.fixedDeltaTime);
    }
}