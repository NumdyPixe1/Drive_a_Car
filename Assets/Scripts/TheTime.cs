using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TheTime : MonoBehaviour
{

  
    public Text GameOverText;
    public Text NumberTimeText;
    public Text TimeText;
    public bool GameOver = false;
    //private float currentGas;
    public float CurrentTime = 30;
    
    

    
    void Start()
    {
        //currentGas = starGas;

        NumberTimeText.text = "";
        TimeText.text = "Time : ";

}

    
    void Update()
    {
        if (GameOver)
        {
            return;
           
        }
        CurrentTime -= 1 * Time.deltaTime;
        //currentGas -= 1 * Time.deltaTime;
        NumberTimeText.text = CurrentTime.ToString("0");//ไม่มีทศนิยม 
        if (CurrentTime <= 0) 
        {
            GameOver = true;
            TimeText.text = ("");
            NumberTimeText.text = ("");
            GameOverText.text = ("Game Over");
            CurrentTime = 0;
           
        }
        
    }
    public void SlowDown()
    {
        Time.timeScale = -1f;
    }

    //test
      public void AddTime(int amount)
    {
        CurrentTime += amount;
        if (amount < 0)
        {

        } 
            //SlowDown();
        
        //currentGas += amount;
        // if (amount < 0)
        //{
        //   currentGas -= 5 * Time.deltaTime;
        //}

    }
}
