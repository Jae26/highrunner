using System.Collections;
using UnityEngine;

public class Spinner : MonoBehaviour
{

    public void SpinLeft()
    {
        //transform.Translate(Vector3.left * Time.deltaTime);
        //print(transform.position.x);
        transform.Rotate(0, 0, 60 * Time.deltaTime);
    }

    
    public void SpinRight()
    {
        //transform.Translate(Vector3.right * Time.deltaTime);
        transform.Rotate(0, 0, -60 * Time.deltaTime);
    }
	
}
