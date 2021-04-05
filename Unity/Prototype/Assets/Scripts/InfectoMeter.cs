using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InfectoMeter : MonoBehaviour
{
    public Slider slider;

    public void SetMaxInfection(int infection)
    {
        slider.maxValue = infection;
        slider.value = infection;
    }
    public void SetMinInfection(int infection)
    {
        slider.minValue = infection;
        slider.value = infection;
    }

    public void SetInfection(int infection)
    {
        slider.value = infection;
    }
}
