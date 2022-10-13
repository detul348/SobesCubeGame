using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Cubes : MonoBehaviour
{
   private string SpeedText;
   private string DistanceText;
   private string TimeForAppearenceText;
   public int Speed;
   public int Distance;
   public int Time;
   public InputField mainInputField;
   public enum Tables
   {
      Speed, Distance, TimeForAppearence
   }

   public Tables _tables;
   public void Start()
   {
      //добавляем слушателя
      mainInputField.onValueChange.AddListener (delegate {ValueChangeCheck (mainInputField.text);});
   }

   // когда происходит набор текста проверяем его
   public void ValueChangeCheck(string text)
   {
      switch (_tables)
      {
         case Tables.Distance:
            DistanceText = mainInputField.text;
            Distance = Int32.Parse(DistanceText);
            break;
         case Tables.Speed:
            SpeedText = mainInputField.text;
            Speed = Int32.Parse(SpeedText);
            break;
         case Tables.TimeForAppearence:
            TimeForAppearenceText = mainInputField.text;
            Time = Int32.Parse(TimeForAppearenceText);
            break;
      }
   }
}
