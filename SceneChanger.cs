using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;


    public class SceneChanger : MonoBehaviour
    {

        //public GameObject SceneTrigger;
        public GameObject WomanCheck;
        public GameObject WellCheck;


        
        void Start()
        {
        //SceneTrigger.SetActive(true);
        }

        private void OnTriggerEnter(Collider other)
        {
            if (WomanCheck.GetComponent<SpawnWoman>().womanSpawned == true)
            {
                if (WellCheck.GetComponent<WellEvent>().WellInteracted == true)
                {
                    if (other.gameObject.CompareTag("Player"))
                    {
                        SceneManager.UnloadSceneAsync("Demo1 Night");
                        SceneManager.LoadSceneAsync("MultiLevel_House", LoadSceneMode.Single);
                    }
                }
            }
        }
    }

