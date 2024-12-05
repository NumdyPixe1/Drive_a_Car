using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomEtc : MonoBehaviour
{
    public GameObject CactusRight;
    public GameObject CactusLetf;
    public GameObject RockLetf;
    public float timeElapsed = 0;
    public float ObjectDelay = 0.5f;
    bool CactusNRock = true;

    void Update()
    {
        timeElapsed += Time.deltaTime;
        if (timeElapsed > ObjectDelay)
        {
            GameObject _object1;
            if (CactusNRock)
            {
                _object1 = (GameObject)Instantiate(CactusLetf);
                Vector3 pos = _object1.transform.position;
                _object1.transform.position = new Vector3(Random.Range(-33.6f, -5.85f), -3.8f, 75f);

               _object1 = (GameObject)Instantiate(CactusRight);
                Vector3 pos1 = _object1.transform.position;
                _object1.transform.position = new Vector3(Random.Range(33.6f, 5.85f), -3.8f, 75f);

            }
           else
            {
                _object1 = (GameObject)Instantiate(RockLetf);
                Vector3 pos = _object1.transform.position;
                _object1.transform.position = new Vector3(Random.Range(-21.61f, -8.27f),pos.y, 75f);

                _object1 = (GameObject)Instantiate(RockLetf);
                Vector3 pos1 = _object1.transform.position;
                _object1.transform.position = new Vector3(Random.Range(21.61f, 8.27f), pos.y, 75f);
            }
            timeElapsed -= ObjectDelay;
            CactusNRock = !CactusNRock;
        }


    }
}