using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ObjectScript : MonoBehaviour
{//��˹�ҷ���������­��ع
    
    public int Rotatespeed = 100;
    void Update()
    {
        transform.Rotate(Vector3.back * Rotatespeed * Time.deltaTime);//test
    }
}
