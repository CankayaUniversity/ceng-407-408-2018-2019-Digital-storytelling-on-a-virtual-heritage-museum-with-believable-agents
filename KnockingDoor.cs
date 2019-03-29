using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnockingDoor : MonoBehaviour
{
    public float TheDistance;
   // public GameObject ActionDisplay;
   // public GameObject ActionText;
    public GameObject TheDoor; //this is the parent object, prefab
    public AudioSource KnockingSound;

    void Update()
    {
       
       TheDistance = PlayerCasting.DistanceFromTarget;
    }

    void OnMouseOver()
    {
        if (TheDistance <= 2)
        {
           // ActionDisplay.SetActive(true);
           // ActionText.SetActive(true);
        }
        if (Input.GetButtonDown("Action"))
        {
            if (TheDistance <= 2)
            {
                this.GetComponent<BoxCollider>().enabled = false;
                Debug.Log("You are near the door");
                // ActionDisplay.SetActive(false);
                // ActionText.SetActive(false);
                TheDoor.GetComponent<Animation>().Play("Knock");
                // TheDoor.GetComponent<Animation>().Play("Knock");
                
                KnockingSound.Play();
                this.transform.parent.gameObject.tag = "KnockedDoor";
                Debug.Log(this.transform.parent.gameObject.tag);
                TheDoor.transform.parent.GetComponent<SpawnWoman>().knockedDoorCount++;

            }
        }
    }

   void OnMouseExit()
   {
       //ActionDisplay.SetActive(false);
       //ActionText.SetActive(false);
   }
}
