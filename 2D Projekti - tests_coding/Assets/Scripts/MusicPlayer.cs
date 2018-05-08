using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayer : MonoBehaviour {
    static MusicPlayer instance = null;

    private void Awake()
    {
        if (instance != null)
        {
            Destroy(gameObject);
            Debug.Log("destroyed");
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(gameObject);

        }
    }

    // Use this for initialization
    void Start () {
        
        }
    
    // Update is called once per frame
    void Update () {
        
    }
}
