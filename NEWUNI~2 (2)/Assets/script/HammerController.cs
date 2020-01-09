using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HammerController : MonoBehaviour
{
    GameObject director;
    int point = 0;

    public AudioClip didaSE;
    public AudioClip bombSE;
    AudioSource aud;

    public Vector3 _hit_point;

    // Start is called before the first frame update
    void Start()
    {
        this.director = GameObject.Find("GameDirector");
        this.aud = GetComponent<AudioSource>();
    }

    // Update is called once per frame
     void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if(Physics.Raycast(ray, out hit, Mathf.Infinity))
            {
                float x = Mathf.RoundToInt(hit.point.x);
                float z = Mathf.RoundToInt(hit.point.z);
                transform.position = new Vector3(x-0.2f, 0.8f, z);
  

            }
        }
    }
    
    void OnTriggerEnter(Collider other)
    {
   
        
        if (other.gameObject.tag == "dida")
        {
            this.director.GetComponent<GameDirector>().GetDiDa();
            this.aud.PlayOneShot(this.didaSE);

        }
        else
        {
            this.director.GetComponent<GameDirector>().GetBomb();
            this.aud.PlayOneShot(this.bombSE);

        }

        
        Destroy(other.gameObject);

    }


   


}

