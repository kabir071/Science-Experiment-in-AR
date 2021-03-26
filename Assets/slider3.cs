using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class slider3 : MonoBehaviour
{
     public static  Text sliderValue3;
 public static  Slider slider3a;
 
 void Update(){
 
 sliderValue3.text = slider3a.value.ToString("0.0");
 
 }
}