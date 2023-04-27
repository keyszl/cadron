using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class NextSceneCollide : MonoBehaviour
{
    public GameObject target;
    public string scene;
    public string requiredletter;

    public void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject == target)
        {
            if((requiredletter != null) && GameManager.Instance.IsLetterDelivered(requiredletter))
            {
            //print to the console
            Debug.Log("Player has exited the trigger");
            GameManager.Instance.ChangeScene(scene);
            }
        }
    }


}
