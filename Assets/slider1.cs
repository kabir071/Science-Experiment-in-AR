using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class slider1 : MonoBehaviour
{

   public static Text sliderValue;
 public static  Slider slider;
 
 void Update(){
 
 sliderValue.text = slider.value.ToString("0.0");
 
 }
}