using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour {
    [HideInInspector] public bool facingRight = true;
    public int speed = 8;
    public int jump_high = 7;
    [SerializeField]Rigidbody2D player;
    private int dir;

    void Move()
    {
        if (dir != 0)
        {
            player.velocity = new Vector2(dir * speed, player.velocity.y);
        }
            
    }

    void Jump()
    {
        player.velocity = new Vector2(dir * speed, jump_high);

    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            dir = 1;
            Move();
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            dir = -1;
            Move();
        } else
        {
            dir = 0;
        }

        if (Input.GetKey(KeyCode.UpArrow) && player.velocity.y == 0)
        {
            Jump();
        }

    }


}
