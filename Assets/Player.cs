using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed;
    public float jumpForce;

    Rigidbody2D rb2d;


    float playerInput;

    [Space]
    public Transform posicaoPe;
    public LayerMask groundLayer;   
    public float tamanhoPe;

    [Space]

    public GameObject pontos;
    
    //https://www.youtube.com/watch?v=fcKGqxUuENk
    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        playerInput = Input.GetAxisRaw("Horizontal");
        if (Input.GetButtonDown("Jump") && IsGrounded())
        {
            rb2d.velocity = new Vector2(rb2d.velocity.x, jumpForce);
        }

        print(pontos.GetComponent<Coletaveis>().coletavel1);

    }

   

    private void FixedUpdate()
    {

        rb2d.velocity = new Vector2(playerInput * speed, rb2d.velocity.y);                            
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Coletavel_1")
        {
            pontos.GetComponent<Coletaveis>().coletavel1++;
            Destroy(collision.gameObject, 0.1f);
        }
        else if(collision.gameObject.tag == "Coletavel_2")
        {
            pontos.GetComponent<Coletaveis>().coletavel2++;
            Destroy(collision.gameObject, 0.1f);
        }
        else if(collision.tag == "Coletavel_3")
        {
            pontos.GetComponent<Coletaveis>().coletavel3++;
            Destroy(collision.gameObject, 0.1f);
        }
    }


    bool IsGrounded()
    {
        return Physics2D.OverlapCircle(posicaoPe.position, tamanhoPe, groundLayer);
    }
}
