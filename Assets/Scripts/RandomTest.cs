using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomTest : MonoBehaviour
{
	public GameObject Rock;
	public GameObject Coin;
	public GameObject Coin3;
	public GameObject Timeobject;

	public float timeElapsed = 1;		//เวลาที่ผ่านไป
	public float ObjectDelay = 0.5f;    //วัตถุดีเลย์
	bool ShowCoinandTime = true;
    void Update()
    {
		
		timeElapsed += Time.deltaTime;
		
			
		if (timeElapsed > ObjectDelay)
		{
			
			GameObject _object;
			if (ShowCoinandTime)//true
			{
				_object = (GameObject)Instantiate(Coin);
				Vector3 pos = _object.transform.position;
				_object.transform.position = new Vector3(Random.Range(-3.80f, 3.80f), -3, 50f);

				_object = (GameObject)Instantiate(Coin3);
				Vector3 pos1 = _object.transform.position;
				_object.transform.position = new Vector3(Random.Range(-3.80f, 3.80f), -3, 45f);

				_object = (GameObject)Instantiate(Timeobject);
				Vector3 pos2 = _object.transform.position;
				_object.transform.position = new Vector3(Random.Range(-3.80f, 3.80f), -3f, 65f);

			}
			else //false

			{
				_object = (GameObject)Instantiate(Rock);
				Vector3 pos = _object.transform.position;
				_object.transform.position = new Vector3(Random.Range(-3.80f, 3.80f), -3.8f, 45f);
				

			}
				
				timeElapsed -= ObjectDelay;
			ShowCoinandTime = !ShowCoinandTime;
		}
	}
	
}
