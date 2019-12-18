using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pythagoras : MonoBehaviour
{
    public int value;
    public float a;
    public float b;

    // Start is called before the first frame update
    void Start()
    {
        //int Result = Square(Value) + Square(Value);
        //Debug.Log("result Addition:" + Result);
        PythagorasMethod(a,b);
        float result = PythagorasMethod(a, b) + PythagorasMethod(a, b);
        Debug.Log("Result: " + result);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    int Square(int VarA)
    {
        Debug.Log(VarA * VarA);
        return VarA * VarA;
    }

 
      private void OnValidate()
    {
        //Square(value);
    }

   
     float PythagorasMethod(float a, float b)
    {
        float cSquare;
        cSquare = (a * a) + (b * b);
        float c = Mathf.Sqrt(cSquare);
        Debug.Log("cSquare: " + cSquare);
        Debug.Log("c: " + c);
        return c;
    }

}
