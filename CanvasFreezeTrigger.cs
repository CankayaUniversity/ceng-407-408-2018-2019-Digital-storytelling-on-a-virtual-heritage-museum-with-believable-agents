using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class CanvasFreezeTrigger : MonoBehaviour
{
    public GameObject QuestionCanvas;
    public GameObject Karacongolos;
    public FirstPersonController FPSContoller;
    // public GameObject ScriptOnOff;
    //public GameObject FPSContoller;
    //public Animation Anim;
  
     


    private void Start()
    {
        Karacongolos.SetActive(false);
        FPSContoller.GetComponent<FirstPersonController>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {

            Debug.Log("girdi");
            Karacongolos.SetActive(true);
            QuestionCanvas.SetActive(true);
            FPSContoller.m_UseHeadBob = false;
            FPSContoller.enabled = false;
            //FPSContoller = GameObject.FindWithTag("Player");
            //FPSContoller.GetComponent(FirstPersonController).enable = false;
           




        }
    }
}
