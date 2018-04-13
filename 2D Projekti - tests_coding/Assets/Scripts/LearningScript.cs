using System.Collections;
using UnityEngine;

public class LearningScript : MonoBehaviour
{
    /*
    //string myString = "Access the variable ";
    TalkToMe otherComponent;//declare the outside component and make it into a variable

    private void Start()
    {
        otherComponent = GetComponent<TalkToMe>();
        //variable's value is what component is attached to in Unity
        //<T> is the type of component/class name the method will return
        //with this we can use 'otherComponent' instead of using 'GetComponent<TalkToMe>()'

        Debug.Log("Press the Return key.");//instructions to the 'player'
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Return))//actionable 'if' statement
        {
            Debug.Log("This is the TalkToMe Component: " + otherComponent);
            //"This is the TalkToMe Component: Main Camera"
            //display string + variable's value (in this case the gameObject attached)

            Debug.Log(otherComponent.hereItIs);
            //"This is the TalkToMe variable"
            //calls the public variable value from the 'TalkToMe' component

            otherComponent.MakeMeTalk();
            //"This is the TalkToMe method"
            //executes the outside called method
        }
    }

    private void Start()
    {
        Debug.Log("Press the Return key.");
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log(myString + "the normal way.");
            //string is displayed normally in console (use within class/script/component)

            Debug.Log(this.myString + "using 'this' keyword");
            //access the variable from within the component using 'this' + '.'

            Debug.Log(GetComponent<LearningScript>().myString + "using GetComponent");
            // access the variable from the called script using 'GetComponent';
            // NOTE: if the variable is public this 'method' can be used to access the 
            //variable from another class/script

            Debug.Log(this); //find out what this script is attached, currently
            Debug.Log(GetComponent<LearningScript>());
            //find out again what object this script is attached
        }
    }*/


    GameObject capsuleGO;
    Spinner cubeComp;
    //GameObject cubeComp;

    void Start ()
    {
        capsuleGO = GameObject.Find("Capsule");
        //cubeComp = GameObject.Find("Cube");
        Debug.Log(capsuleGO);
        //cubeComp = GameObject.Find("Cube").GetComponent<Spinner>();
        //Debug.Log(cubeComp);
    }

    void Update ()
    {
        if(Input.GetKey(KeyCode.LeftArrow))
        {
            capsuleGO.GetComponent<Spinner>().SpinLeft();
        }

        if(Input.GetKey(KeyCode.RightArrow))
        {
            capsuleGO.GetComponent<Spinner>().SpinRight();
        }

        if(Input.GetKey(KeyCode.UpArrow))
        {
            cubeComp.SpinLeft();
        }

        if(Input.GetKey(KeyCode.DownArrow))
        {
            cubeComp.SpinRight();
        }
    }
}
