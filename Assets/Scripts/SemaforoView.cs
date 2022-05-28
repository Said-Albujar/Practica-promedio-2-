using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SemaforoView : MonoBehaviour
{
    public SemaforoController controller;

   
    void Update()
    {

        controller.DescVerd();
        controller.DescAmar();
        controller.DescRed();
    }
}
