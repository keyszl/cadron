using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class BackpackScript : MonoBehaviour
{
    public GameObject Backpackbutton;

    public void OpenBackpack(){
        if(!GameManager.Instance.IsPaused()){
        gameObject.SetActive(true);
        GameManager.Instance.PauseGame();    
        }
        

    }
    public void CloseBackpack(){
        gameObject.SetActive(false);
        GameManager.Instance.UnpauseGame();
        Backpackbutton.SetActive(true);
    
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(GameManager.Instance.IsPaused()){
            Backpackbutton.SetActive(false);
        }
        else
        Backpackbutton.SetActive(true);
    }
}
