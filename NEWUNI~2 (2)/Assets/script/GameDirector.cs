using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameDirector : MonoBehaviour
{
    // Start is called before the first frame update
    GameObject pointText;
    GameObject timeText;
    GameObject director;
    GameObject genterator;

    float time = 60.0f;
    int point = 0;

    void Start()
    {
        
        this.genterator = GameObject.Find("ItemGenerator");
        this.director = GameObject.Find("Gamedirector");
        this.timeText = GameObject.Find("Time");
        this.pointText = GameObject.Find("Point");
    }

    // Update is called once per frame
    void Update()
    {

        this.time -= Time.deltaTime;
 
        this.timeText.GetComponent<Text>().text = this.time.ToString("F1");
        this.pointText.GetComponent<Text>().text = this.point.ToString() + "point";

        if (this.timeText.GetComponent<Text>().text == "0.0")
        {
            SceneManager.LoadScene("OverScene");
        }
        else if(this.timeText.GetComponent<Text>().text == "20.0"){
            this.genterator.GetComponent<ItemGenerator>().SetParameter(0.4f, -0.06f, 6);
        }
        else if(this.timeText.GetComponent<Text>().text == "40.0")
        {
            this.genterator.GetComponent<ItemGenerator>().SetParameter(1.0f, -0.03f,2);
        }



    }

    public void GetDiDa()
    {
        this.point += 100;
    }

    public void GetBomb()
    {
        this.point /= 2;
    }
}
