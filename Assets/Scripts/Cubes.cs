using System;
using UnityEngine;
using UnityEngine.UI;

public class Cubes : MonoBehaviour
{
    [field: SerializeField] public int Speed { get; private set; }
    [field: SerializeField] public int Distance { get; private set; }
    [field: SerializeField] public int Time { get; private set; }

    private string _speedText;
    private string _distanceText;
    private string _timeForAppearenceText;

    public InputField mainInputField;

    public enum tables
    {
        Speed,
        Distance,
        TimeForAppearence
    }

    public tables Tables;

    private void Start()
    {
        mainInputField.onValueChange.AddListener(delegate { ValueChangeCheck(mainInputField.text); });
    }
    
    private void ValueChangeCheck(string text)
    {
        switch (Tables)
        {
            case tables.Distance:
                _distanceText = mainInputField.text;
                Distance = Int32.Parse(_distanceText);
                break;
            case tables.Speed:
                _speedText = mainInputField.text;
                Speed = Int32.Parse(_speedText);
                break;
            case tables.TimeForAppearence:
                _timeForAppearenceText = mainInputField.text;
                Time = Int32.Parse(_timeForAppearenceText);
                break;
        }
    }
}