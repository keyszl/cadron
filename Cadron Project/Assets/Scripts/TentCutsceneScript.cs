using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TentCutsceneScript : MonoBehaviour
{

    public string charname;
    public string[] dialogLines;

    public int whichTentScene;

    public Sprite portrait;


    void Awake()
    {
       
    }
    // Start is called before the first frame update
    void Start()
    {
        if(GameManager.Instance.GetTentscene() == whichTentScene){
         GameManager.Instance.ToCutscene(dialogLines, charname, portrait);    
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
