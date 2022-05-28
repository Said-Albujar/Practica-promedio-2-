using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SemaforoController : MonoBehaviour
{
    public SemaforoModel model;
    public float TotalTime=75f;
    
    public float ChangeTime;
    public float timer_done=0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        DescRed();
        
    }
    public void DescRed()
    {
        float t = 40f;
        ChangeTime = t;
        timer_done += Time.deltaTime;
        if (timer_done >= ChangeTime)

        {
            
            model.luzroja.SetActive(false);
           if(timer_done >= 75f)
            {
                model.luzroja.SetActive(true);
                timer_done = 0;
            }
            
        }
        
    }
    public void DescAmar()
    {
        float t = 40f;
        ChangeTime = t;
        timer_done += Time.deltaTime;
        if (timer_done >= ChangeTime)

        {

            model.luzamarilla.SetActive(false);
            if (timer_done >= 35f)
            {
                model.luzamarilla.SetActive(true);
                timer_done = 0;
            }

        }

    }
    public void DescVerd()
    {
        float t = 45f;
        ChangeTime = t;
        timer_done += Time.deltaTime;
        if (timer_done >= ChangeTime)

        {

            model.luzverde.SetActive(false);
            if (timer_done >= 30f)
            {
                model.luzverde.SetActive(true);
                timer_done = 0;
            }

        }

    }


}
