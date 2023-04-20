using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DisplayLetterName : MonoBehaviour
{
    public TextMeshProUGUI text;

    void awake(){
        text.text = gameObject.name;
    }
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
        text.text = gameObject.name;
       
    }
}
