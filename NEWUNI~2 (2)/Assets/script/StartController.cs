using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartController : MonoBehaviour
{
    float delta = 2.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.delta -= Time.deltaTime;
        if(delta < 0)
        {
            SceneManager.LoadScene("SampleScene");
        }
    }
}
