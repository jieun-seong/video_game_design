using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ManaBarScript : MonoBehaviour
{
    public Slider slider;
    
    public void SetMana(int health)
    {
        slider.value = health;
    }

    public void SetMaxMana(int health)
    {
        slider.maxValue = health;
        slider.value = health;
    }
}
