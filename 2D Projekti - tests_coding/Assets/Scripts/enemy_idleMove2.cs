using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_idleMove2 : MonoBehaviour
{
    private const int IDLE = 0;
    private const int WALKING = 1;
    private const float IDLE_TIME = 2.0f;
    private const float WALKING_TIME = 1.5f;

    private SpriteRenderer enemySpriteRenderer;
    private bool toRight = true;
    private float deltaX = 0.014f;
    private float idleTimer;
    private float walkTimer;
    Animator anim;
    private int state;
    private float x;
    private float y;

    // Use this for initialization
    void Start()
    {
        enemySpriteRenderer = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();
        state = IDLE;
        idleTimer = IDLE_TIME;
        // current position
        x = transform.position.x;
        y = transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        switch (state)
        {
            case IDLE:
                idleTimer = idleTimer - Time.deltaTime;
                if (idleTimer <= 0f)       // idle over, change to walking state
                {
                    state = WALKING;
                    walkTimer = WALKING_TIME;
                    anim.SetInteger("State", WALKING);
                    // change direction
                    if (toRight)
                    {
                        enemySpriteRenderer.flipX = true;
                        toRight = false;
                    }
                    else
                    {
                        enemySpriteRenderer.flipX = false;
                        toRight = true;
                    }
                }
                break;
            case WALKING:

                walkTimer = walkTimer - Time.deltaTime;
                if (walkTimer <= 0f)      // walking over, change to idle state
                {
                    state = IDLE;
                    anim.SetInteger("State", IDLE);
                    idleTimer = IDLE_TIME;
                }
                else
                {
                    if (toRight) x = x + deltaX;   // increas x-coordinate, i.e. go to right
                    else x = x - deltaX;           // decrease x-koordinate, i.e. go to left
                    transform.position = new Vector2(x, y);   // set new position
                }
                break;
            default:
                break;
        }

    }
}
