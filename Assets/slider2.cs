using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class slider2: MonoBehaviour
{
     public static  Text sliderValue2;
 public static  Slider slider2a;
 
 void Update(){
 
 sliderValue2.text = slider2a.value.ToString("0.0");
 
 }
}