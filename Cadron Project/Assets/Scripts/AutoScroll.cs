using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class AutoScroll : MonoBehaviour
{
    // a script that scrolls the text upwards, like generic movie credits, or the end of a game
    // https://youtu.be/9a6GyAbhLUk?t=799

    private float speed = 200.0f;
    private float boundaryStart = -4000.0f;
    private float boundaryEnd = 5850.0f;
    public RectTransform rectTransform;

    public TextMeshProUGUI text;
    
    bool isLooping = false;


    // Start is called before the first frame update
    void Start()
    {
        rectTransform = gameObject.GetComponent<RectTransform>();
        StartCoroutine(AutoScrolltxt());
    }

    IEnumerator AutoScrolltxt()
    {
        while (rectTransform.localPosition.y < boundaryEnd)
        {
            rectTransform.Translate(Vector3.up * Time.deltaTime * speed);
            if(rectTransform.localPosition.y > boundaryEnd)
            {
                if (isLooping)
                {
                    rectTransform.localPosition = Vector3.up * boundaryStart;
                }
                else
                {
                    break;
                }
            }
            yield return null;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
