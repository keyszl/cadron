using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BackpackLetterPopup : MonoBehaviour
{
    public GameObject newLetter;
    public void ShowNewLetter(){
        StartCoroutine(FlashLetter());
        StartCoroutine(FlashLetter());
    }

    IEnumerator FlashLetter(){
        float time = 0;
        float duration = 1.5f;
        Color startValue = new Color (1,1,1,1);
        Color endValue = new Color(1, 1, 1, 0);
        Image bplimage = newLetter.GetComponent<Image>();

        while (time < duration)
        {
            bplimage.color = Color.Lerp(startValue, endValue, time / duration);
            time+= Time.deltaTime;
            yield return null;
        }
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
