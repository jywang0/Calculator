using System.Collections;
using System.Collections.Generic;
using UnityEngine.UIElements;
using UnityEngine.UI;
using UnityEngine;
using Calculator;

public class CalculatorManager : MonoBehaviour
{
    public InputField input_a;
    public InputField input_b;
    public Text result;
    private Calc c;

    public void Start()
    {
        c = new Calc();
    }

    public void Add()
    {
        Debug.Log(c.Add(int.Parse(input_a.text), int.Parse(input_b.text)));
    }

    public void Subtract()
    {
        Debug.Log(c.Subtract(int.Parse(input_a.text), int.Parse(input_b.text)));
    }

    public void Divide()
    {
        Debug.Log(c.Divide(int.Parse(input_a.text), int.Parse(input_b.text)));
    }

    public void Time()
    {
        Debug.Log(c.Time(int.Parse(input_a.text), int.Parse(input_b.text)));
    }
}
