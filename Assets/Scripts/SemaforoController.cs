using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SemaforoController : MonoBehaviour
{
    public SemaforoModel model;


    public float ChangeTime;
    public float timer_done = 0;



    public void DescRed()
    {
        float t = model.tiemporojo;
        ChangeTime = t;
        timer_done += Time.deltaTime;
        if (timer_done >= ChangeTime)
        {
            
            model.luzroja.SetActive(false);
           if(timer_done >= 75f)
           {
                model.luzroja.SetActive(true);
                
           }
            
        }
        
    }
    public void DescAmar()
    {
        float t = model.tiempoamar;
        ChangeTime = t;
        timer_done += Time.deltaTime;
        if (timer_done >= ChangeTime)
        {

            model.luzamarilla.SetActive(true);
            if (timer_done >= 45f)
            {
                model.luzamarilla.SetActive(false);
                
            }

        }

    }
    public void DescVerd()
    {
        float t = model.tiempoverde;
        ChangeTime = t;
        timer_done += Time.deltaTime;
        if (timer_done >= ChangeTime)
        {

            model.luzverde.SetActive(true);
            if (timer_done >= 75f)
            {
                model.luzverde.SetActive(false);
                timer_done = 0;
            }

        }

    }









}
