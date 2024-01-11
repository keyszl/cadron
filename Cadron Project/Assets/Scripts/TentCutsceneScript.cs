using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TentCutsceneScript : MonoBehaviour
{

    public string charname;
    public string[] dialogLines;

    public int whichTentScene;

    public Sprite portrait;

    public GameObject picture;


    void Awake()
    {
       
    }
    // Start is called before the first frame update
    void Start()
    {
        if(GameManager.Instance.GetTentscene() == whichTentScene){
         picture.SetActive(true);
         GameManager.Instance.ToCutscene(dialogLines, charname, portrait);    
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
