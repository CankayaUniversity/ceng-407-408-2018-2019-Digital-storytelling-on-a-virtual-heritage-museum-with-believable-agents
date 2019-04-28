using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MuseumC;
public class CandleScript : MonoBehaviour
{
    public GameObject GameOverMenu;
    //private GameManager_Master gm;
    public GameObject Candle1_f1;
    public GameObject Candle1_f2;
    public GameObject Candle1_f3;
    public GameObject Candle1_f4;

    public GameObject Candle2_f1;
    public GameObject Candle2_f2;
    public GameObject Candle2_f3;
    public GameObject Candle2_f4;

    public GameObject Candle3_f1;
    public GameObject Candle3_f2;
    public GameObject Candle3_f3;
    public GameObject Candle3_f4;

    public GameObject Candle4_f1;
    public GameObject Candle4_f2;
    public GameObject Candle4_f3;
    public GameObject Candle4_f4;

    private int flames = 0;

    // Start is called before the first frame update
    void Start()
    {
        //Candle1_f1.SetActive(false);
        GameOverMenu.SetActive(false);
        
    }

    // Update is called once per frame
    void Update()
    {


        if (flames == 0)
        {
            
            GameOverMenu.SetActive(true);
            
        }
    }
}
