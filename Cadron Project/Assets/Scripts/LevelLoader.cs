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
  public string scene;

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
        StartCoroutine(LoadLevel(scene));
    }
    

    IEnumerator LoadLevel(string level)
    {
      transition.SetTrigger("Start");

      yield return new WaitForSeconds(transitionTime);

      SceneManager.LoadScene(level);
      GameManager.Instance.ClearLetters();
    }

}