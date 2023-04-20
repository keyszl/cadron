using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
public class BackpackScript : MonoBehaviour
{
    public GameObject LetterPrefab;

    public TextMeshProUGUI LetterTextPrefab;
    public GameObject Backpackbutton;

    public GameObject letterbox;
    private Dictionary<string, bool> letters;
   
    public void OpenBackpack(){
        if(!GameManager.Instance.IsPaused()){
        
        GameManager.Instance.PauseGame(); 
        letters = GameManager.Instance.GetLetters();
        Vector2 letterpos = new Vector2(-200,135);
        foreach(KeyValuePair<string, bool> letter in letters){
            string to = letter.Key;
            if(letter.Value == false){
                GameObject newletter = Instantiate(LetterPrefab);
                newletter.transform.SetParent(letterbox.transform);
                newletter.GetComponent<RectTransform>().anchoredPosition = letterpos;
                newletter.name = to;
                letterpos.x = letterpos.x + 135;
                if(letterpos.x % 205 == 135){
                    letterpos.y = letterpos.y - 100;
                    letterpos.x = -200;
                }
            }
        }
        gameObject.SetActive(true);
        }
        

    }
    public void CloseBackpack(){
        gameObject.SetActive(false);
        GameManager.Instance.UnpauseGame();
        Backpackbutton.SetActive(true);
        foreach(Transform child in letterbox.transform){
            GameObject.Destroy(child.gameObject);
        }
    
    }
    void Awake(){
        if(GameManager.Instance.IsPaused()){
            Backpackbutton.SetActive(false);
        }
        else
        Backpackbutton.SetActive(true);
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
