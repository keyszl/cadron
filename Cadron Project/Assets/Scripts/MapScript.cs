using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapScript : MonoBehaviour
{
    public GameObject MapButton;
    public void OpenMap(){
        if(!GameManager.Instance.IsPaused()){
            GameManager.Instance.PauseGame();
            gameObject.SetActive(true);
            MapButton.SetActive(false);
        }
    }

    public void CloseMap(){
        gameObject.SetActive(false);
        GameManager.Instance.UnpauseGame();
        MapButton.SetActive(true);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
