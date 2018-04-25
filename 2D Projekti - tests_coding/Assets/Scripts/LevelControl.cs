using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelControl : MonoBehaviour
{

    public int index;
    public string levelName;

    public Image black;
    public Animator anim;

    private void OnTriggerEnter2D(Collider2D sceneChange)
    {
        if(sceneChange.CompareTag("Player"))
        {
            SceneManager.LoadScene(index);

            //SceneManager.LoadScene(levelName);
        }
    }
}
