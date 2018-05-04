using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelControl : MonoBehaviour
{

    public int index;
    public string levelName;
    /*
    public Image black;
    public Animator anim;*/


    IEnumerator SceneChange()
    {
        float fadeTime = GameObject.Find("EndLevelFlower").GetComponent<Fading>().BeginFade(1);
        yield return new WaitForSeconds(fadeTime);
    }
    private void OnTriggerEnter2D(Collider2D sceneChange)
    {
        if(sceneChange.CompareTag("Player"))
        {
            SceneManager.LoadScene(index);
            //Application.LoadLevel(Application.loadedLevel + 1);
            //SceneManager.LoadScene(levelName);
        }
        
    }
}
