using System;
using UnityEngine;
using UnityEngine.UI;

public class Cubes : MonoBehaviour
{
    [field: SerializeField] public int Speed { get; private set; }
    [field: SerializeField] public int Distance { get; private set };
    [field: SerializeField] public int Time { get; private set };

    private string _speedText;
    private string _distanceText;
    private string _timeForAppearenceText;

    public InputField mainInputField;

    public enum Tables
    {
        Speed,
        Distance,
        TimeForAppearence
    }

    public Tables _tables;

    private void Start()
    {
        //добавляем слушателя
        mainInputField.onValueChange.AddListener(delegate { ValueChangeCheck(mainInputField.text); });
    }

    // когда происходит набор текста проверяем его
    private void ValueChangeCheck(string text)
    {
        switch (_tables)
        {
            case Tables.Distance:
                _distanceText = mainInputField.text;
                Distance = Int32.Parse(_distanceText);
                break;
            case Tables.Speed:
                _speedText = mainInputField.text;
                Speed = Int32.Parse(_speedText);
                break;
            case Tables.TimeForAppearence:
                _timeForAppearenceText = mainInputField.text;
                Time = Int32.Parse(_timeForAppearenceText);
                break;
        }
    }
}