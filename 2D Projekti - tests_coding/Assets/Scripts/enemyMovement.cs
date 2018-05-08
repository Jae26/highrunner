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

    private void Update()
    {
        transform.Translate(Vector2.right * speed * Time.deltaTime);
        RaycastHit2D grounInfo = Physics2D.Raycast(groundDetection.position, Vector2.down, distance);
        if(grounInfo.collider.CompareTag("building") == false)
        {
            if (movingRight == true)
            {
                transform.eulerAngles = new Vector3(0, 180, 0);
                movingRight = false;
            }
            else
            {
                transform.eulerAngles = new Vector3(0, 0, 0);
                movingRight = true;

            }
        }
        RaycastHit2D builingInfo = Physics2D.Raycast(buildingDetection.position, Vector2.right, distance);
        if (builingInfo.collider.CompareTag("building") == true)
        {
            if (movingRight == true)
            {
                transform.eulerAngles = new Vector3(0, 180, 0);
                movingRight = false;
            }
            else
            {
                transform.eulerAngles = new Vector3(0, 0, 0);
                movingRight = true;
            }
        }
    }
}