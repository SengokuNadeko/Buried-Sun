using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    [SerializeField] private float speed = 5.0f;
    [SerializeField] private Animator player_animator;
    [SerializeField] private Rigidbody2D player_rigidbody;
    private Vector2 movement_direction;
    private Vector2 last_movement_direction;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Inputs();
        Movement();
        Animations();
    }

    void Inputs() 
    {
        if(movement_direction.x != 0 || movement_direction.y != 0) 
        {
            //When we get animations, add last movement direction here
            last_movement_direction = movement_direction;
        }

        movement_direction = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")).normalized;
    }

    void Movement() 
    {
        player_rigidbody.velocity = new Vector2(movement_direction.x * speed, movement_direction.y * speed);
    }

    void Animations() 
    {
        player_animator.SetFloat("movement_direction_x", movement_direction.x);
        player_animator.SetFloat("movement_direction_y", movement_direction.y);
        player_animator.SetFloat("last_movement_direction_x", last_movement_direction.x);
        player_animator.SetFloat("last_movement_direction_y", last_movement_direction.y);
        player_animator.SetFloat("movement_magnitude", movement_direction.magnitude);
    }
}
