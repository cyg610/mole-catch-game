using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemController : MonoBehaviour
{
    public float dropspeed = 0.03f;
    float span = 1.3f;
    float delta = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.delta += Time.deltaTime;
        if (this.delta > this.span)
        {
            this.delta *= 0.999f;
            transform.position -= new Vector3(0, 0.01f, 0);
        }
        else
        {

            transform.position += new Vector3(0, 0.01f, 0);
        }
        if (transform.position.y < -0.6f)
        {
            Destroy(gameObject);
        }
    }  
   
}