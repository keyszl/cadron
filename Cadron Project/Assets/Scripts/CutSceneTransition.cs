using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutSceneTransition : MonoBehaviour
{
    // from -https://gamedevbeginner.com/the-right-way-to-lerp-in-unity-with-examples/#lerp_vector2
    public Vector2 positionToMoveTo;

    void Start()
    {
        StartCoroutine(LerpPosition(positionToMoveTo, 5));
    }
    IEnumerator LerpPosition(Vector2 targetPosition, float duration)
    {
        float time = 0;
        Vector2 startPosition = transform.position;
        while (time < duration)
        {
            transform.position = Vector2.Lerp(startPosition, targetPosition, time / duration);
            time += Time.deltaTime;
            yield return null;
        }
        transform.position = targetPosition;
    }
}
