using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class NextSceneCollide : MonoBehaviour
{
    public string nextscene;
    public int whichscene;
    public string requiredletter;

    public void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.CompareTag("Player"))
        {
            if((requiredletter == "") || GameManager.Instance.IsLetterDelivered(requiredletter))
            {
            
            //print to the console
            Debug.Log("Player has exited the trigger");
            GameManager.Instance.StartTentscene(whichscene, nextscene);
            }
        }
    }


}
