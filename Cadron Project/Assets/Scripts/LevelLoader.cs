using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelLoader : MonoBehaviour
{
  public Animator transition;

  public float transitionTime;

  public Button myButton;

    void Start(){
      Button btn = myButton.GetComponent<Button>();
      btn.onClick.AddListener(LoadNextLevel);
    }
    // Update is called once per frame
    void Update()
    {
        //if(Input.GetMouseButtonDown(0))
        //{
         //  LoadNextLevel();
        //}
    }

    public void LoadNextLevel()
    {
        StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex + 1));
    }
    

    IEnumerator LoadLevel(int LevelIndex)
    {
      transition.SetTrigger("Start");

      yield return new WaitForSeconds(transitionTime);

      SceneManager.LoadScene(LevelIndex);
    }

}