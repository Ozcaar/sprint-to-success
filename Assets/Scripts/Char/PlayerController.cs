using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float speed = 5f; // Velocidad de movimiento del jugador

    private Rigidbody2D rb;
    

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Captura de entrada del teclado
        float moveHorizontal = Input.GetAxisRaw("Horizontal");
        float moveVertical = Input.GetAxisRaw("Vertical");

        // Calcula el vector de movimiento
        Vector2 movement = new Vector2(moveHorizontal, moveVertical).normalized;

        // Aplica movimiento al jugador
        rb.velocity = movement * speed;

        // Si no hay entrada, detén el movimiento
        if (movement == Vector2.zero)
        {
            rb.velocity = Vector2.zero;
        }
    }
}
