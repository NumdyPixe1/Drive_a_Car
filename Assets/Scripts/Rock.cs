using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rock : MonoBehaviour
{
    public float Speed = 20f;

     void Update()
    {
        transform.Translate(Vector3.back * Time.deltaTime * Speed); 
    }
    private void OnTriggerEnter(Collider other)//-Score และ -Time
    {

        if (other.tag == "Player")
        {
            Destroy(gameObject);

        }
    }
}
