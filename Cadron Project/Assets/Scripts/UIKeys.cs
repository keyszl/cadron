using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIKeys : MonoBehaviour
{

    public GameObject BackpackMenu;
    public GameObject MapMenu;
    // Start is called before the first frame update
    void Start()
    {
        if(BackpackMenu == null){
        BackpackMenu = gameObject.transform.Find("BackpackMenu").gameObject;
        }
        if(MapMenu == null){
        MapMenu = gameObject.transform.Find("MapMenu").gameObject;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.B)){
            if(BackpackMenu.activeSelf == false){
                BackpackMenu.GetComponent<BackpackScript>().OpenBackpack();
            }
            else{
                BackpackMenu.GetComponent<BackpackScript>().CloseBackpack();
            }
            
        }
        else if(Input.GetKeyDown(KeyCode.M)){
          if(MapMenu.activeSelf == false){
                MapMenu.GetComponent<MapScript>().OpenMap();
            }
            else{
                MapMenu.GetComponent<MapScript>().CloseMap();
            }  
        }
    }
}
