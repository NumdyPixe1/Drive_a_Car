using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class forward : MonoBehaviour
{//‡¥‘πÀπÈ“
//‡°Á∫score
    public float speed = 24f;//§«“¡‡√Á«
    void OnTriggerEnter(Collider other)
    {

        

        if (other.name == "Player")
        {
            other.GetComponent<PlayerScript>().score += 1;//∫«°Score
            Destroy(gameObject);//≈∫Object
        }
    }
   
    void Start()
    {
        
    }

    void Update()
    {
        transform.Translate(Vector3.back * Time.deltaTime * speed); //Space.World
    }
}
