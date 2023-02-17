using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public float speed = 5.0f;
    public Rigidbody2D player_rigidbody;
    private Vector2 movement_direction;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Inputs();
        Movement();
    }

    void Inputs() 
    {
        if(movement_direction.x != 0 || movement_direction.y != 0) 
        {
            //When we get animations, add last movement direction here
        }

        movement_direction = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")).normalized;
    }

    void Movement() 
    {
        player_rigidbody.velocity = new Vector2(movement_direction.x * speed, movement_direction.y * speed);
    }
}
