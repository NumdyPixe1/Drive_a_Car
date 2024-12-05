using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoneyScript : MonoBehaviour
{
    public float speed = 2f;//§«“¡‡√Á«
    public AudioClip CoinSound;
   
    void OnTriggerEnter(Collider other)
    {
        if (other.name == "Player")
        {
            AudioSource.PlayClipAtPoint(CoinSound, transform.position);
            other.GetComponent<PlayerScript>().score += 1;//∫«°Score
            Destroy(gameObject);
        }
    }
    void Update()
    {
         transform.Translate(new Vector3(0f, speed, 0f) * Time.deltaTime);
    }
}
