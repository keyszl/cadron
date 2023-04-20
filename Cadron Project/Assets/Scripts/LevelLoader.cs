using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{

    public Animator transition;
    public float transtionTime = 1f;
    
    //https://www.youtube.com/watch?v=CE9VOZivb3I
    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            LoadNextLevel();
        }
    }

    public void  LoadNextLevel()
    {
        StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex + 1));
        
    }

    IEnumerator LoadLevel(int levelIndex)
    {
        //play animation
        transition.SetTrigger("Start");

        // wait
        yeld return new WaitForSeconds(transitionTime);

        //load scene
        SceneManager.LoadScene(levelIndex);
    }
}
