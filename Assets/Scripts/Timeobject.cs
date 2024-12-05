using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timeobject : MonoBehaviour
{
    public float speed = 24f;
    //
    void OnTriggerEnter(Collider other)
    {



        if (other.name == "Player")
        {
            other.GetComponent<PlayerScript>().currentTime += 3;//�ǡScore
            Destroy(gameObject);//źObject
        }
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);//
    }
}
