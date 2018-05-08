using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyMovement : MonoBehaviour {

    public float speed;
    private bool movingRight = true;
    public Transform groundDetection;
    public Transform buildingDetection;
    public float distance;
    public Animator animator;
    private const int IDLE = 0;
    private const int WALKING = 1;
    private float idleTimer;
    private float walkTimer;
    private const float IDLE_TIME = 2.0f;
    private const float WALKING_TIME = 2.0f;

	private void Start()
	{
        idleTimer = IDLE_TIME;
	}

	private void Update()
    {
        transform.Translate(Vector2.right * speed * Time.deltaTime);
        RaycastHit2D grounInfo = Physics2D.Raycast(groundDetection.position, Vector2.down, distance);
        if(grounInfo.collider.CompareTag("building") == false && idleTimer>0)
            
        {
            if (movingRight == true)
            {
                animator.SetInteger("State", WALKING);
                transform.eulerAngles = new Vector3(0, 180, 0);
                movingRight = false;
            }
            else
            {
                animator.SetInteger("State", WALKING);
                transform.eulerAngles = new Vector3(0, 0, 0);
                movingRight = true;

            }
        }
        RaycastHit2D builingInfo = Physics2D.Raycast(buildingDetection.position, Vector2.right, distance);
        if (builingInfo.collider.CompareTag("building") == true)
        {
            if (movingRight == true)
            {
                animator.SetInteger("State", WALKING);
                transform.eulerAngles = new Vector3(0, 180, 0);
                movingRight = false;
            }
            else
            {
                animator.SetInteger("State", WALKING);
                transform.eulerAngles = new Vector3(0, 0, 0);
                movingRight = true;
            }
        }
    }
}