using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class forward : MonoBehaviour
{//�Թ˹��
//��score
    public float speed = 24f;//��������
    void OnTriggerEnter(Collider other)
    {

        

        if (other.name == "Player")
        {
            other.GetComponent<PlayerScript>().score += 1;//�ǡScore
            Destroy(gameObject);//źObject
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
