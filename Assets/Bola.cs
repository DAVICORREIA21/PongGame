using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bola : MonoBehaviour
{
    // Start is called before the first frame update
    public float Speed = 5f;

    void Start()
    {
        float Speedx = Random.Range(0,2) == 0 ? -1 :1;
        float Speedy = Random.Range(0,2) == 0 ? -1 :1;

        GetComponent<Rigidbody>().velocity = new Vector3(Speed * Speedx , Speed * Speedy,0f); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
