using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{
    [Header("Controls")]
    public Joystick joystick;
    public float horizontalSensitivity;
    public float verticalSensitivity;

    public float playerSpeed = 12.0f;
    public CharacterController controller;
    public float gravity = -9.81f;
    public float jumpHeight = 1.0f;

    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;
    bool isGrounded;

    [Header("MiniMap")]
    public GameObject miniMap;

    [Header("HealthBar")]
    public HealthBarScreenSpaceController healthBar;

    [Header("Player Abilities")]
    [Range(0, 100)]
    public int health;

    public InventoryPanel inventory;

   // Inventory inventory;
    Vector3 velocity;
    // Update is called once per frame

    private void Start()
    {
        inventory.ItemUsed += Inventory_ItemUsed;
    }

    private void Inventory_ItemUsed(object sender, InventoryEventArgs e)
    {
        InventoryItemBase item = e.Item;

        health = healthBar.MaxHealth;

        
    }

    void Update()
    {
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

        if(isGrounded && velocity.y < 0)
        {
            velocity.y = -3f;
        }

        float x = joystick.Horizontal;
        float z = joystick.Vertical;

        Vector3 move = transform.right * x + transform.forward * z;

        controller.Move(move * playerSpeed * Time.deltaTime);

        velocity.y += gravity * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);

        /*      if(KeyBindingManager.GetKeyDown(KeyAction.jump) && isGrounded)
            *//*  {
                  velocity.y = Mathf.Sqrt(jumpHeight * -3f * gravity);
              }*/
    }
    void Jump()
    {
        velocity.y = Mathf.Sqrt(jumpHeight * -2.0f * gravity);
    }

    public void OnJumpButtonPressed()
    {
        if (isGrounded)
        {
            Jump();
        }
    }
    void ToggleMinimap()
    {
        // toggle the MiniMap on/off
        miniMap.SetActive(!miniMap.activeInHierarchy);
    }
    public void OnMapButtonPressed()
    {
        ToggleMinimap();
    }

    private static PlayerBehaviour instance;

    public static PlayerBehaviour MyInstance
    {
        get
        {
            if (instance == null)
            {
                instance = FindObjectOfType<PlayerBehaviour>();
            }
            return instance;
        }
    }

    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        InventoryItemBase item = hit.collider.GetComponent<InventoryItemBase>();
        if(item != null)
        {
            inventory.AddItem(item);
           // Destroy(this.gameObject);
        }
    }
}
