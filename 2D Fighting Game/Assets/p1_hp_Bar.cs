using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class p1_hp_Bar : MonoBehaviour
{
    public Slider slider;
    public void SetMaxHealth(int HP){
        slider.maxValue=HP;
        slider.value=HP;
    }
    public void setHealth(int HP){

        slider.value= HP;

    }
}
