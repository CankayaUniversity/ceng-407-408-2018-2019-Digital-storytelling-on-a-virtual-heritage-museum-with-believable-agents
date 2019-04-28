using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class WellEvent : MonoBehaviour
{

    public GameObject TriggerCam;
    public Camera mainCamera;
    public FirstPersonController playerScript;
    public GameObject FPSController;
    public bool WellInteracted;

    void Start()
    {
        WellInteracted = false;
    }


    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            
            if (Input.GetButtonDown("Action"))
            {
                StartCoroutine(TheSequence());
                WellInteracted = true;
            }
        }
       
        

    }

    IEnumerator TheSequence()
    {

        mainCamera.enabled = false;
        playerScript.enabled = false;
        TriggerCam.SetActive(true);
        TriggerCam.transform.position = FPSController.transform.position;
        
        yield return new WaitForSeconds(3.32f);

        mainCamera.enabled = true;
        playerScript.enabled = true;
        TriggerCam.SetActive(false);
        


    }


}
