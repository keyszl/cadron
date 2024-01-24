using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TimeFade : MonoBehaviour
{


private TextMeshProUGUI text;
private Color newColor;

public void FadeText(){
    StartCoroutine(Fade());
}
IEnumerator Fade(){
    float time = 0;
    float duration = 4f;
    Color startValue = new Color (0,0,0,1);
    Color endValue = new Color(0, 0, 0, 0);
    text = gameObject.GetComponent<TextMeshProUGUI>();
    yield return new WaitForSeconds(2);
    while (time < duration)
        {
            newColor = Color.Lerp(startValue, endValue, time / duration);
            text.color = newColor;
            time+= Time.deltaTime;
            yield return null;
        }
}
    
    // Start is called before the first frame update
    void Start()
    {
        FadeText();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
