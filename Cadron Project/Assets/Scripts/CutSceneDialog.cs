using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class CutSceneDialog : MonoBehaviour
{
    public string[] lines;
    private int line;
    public TextMeshProUGUI charactername;
    public GameObject characterportrait;
    public GameObject nextButton;
    public TextMeshProUGUI nexttext;

    public void nextClick(){
        if(line == lines.Length - 1)
        {
        GameManager.Instance.EndCutscene();
        }
        else{
            line += 1;
            if(line == (lines.Length - 1)){
            // set button text to done
            nexttext.text = "Done";
            }
            GameManager.Instance.DialogShow(lines[line]);
            
            
        }
        
    }
    public void StartCutscene(string name, Sprite portrait){
        line = 0;
        charactername.text = name;
        characterportrait.GetComponent<Image>().overrideSprite = portrait;
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
