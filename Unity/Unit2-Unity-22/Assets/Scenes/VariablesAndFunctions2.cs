using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariablesAndFunctions2 : MonoBehaviour
{
     int myInt = 2;
    
    
    void Start ()
    {
        myInt = MultiplyByTwo(myInt);
        Debug.Log (myInt);
    }
    
    
    int MultiplyByTwo (int number)
    {
        int result;
        result = number * 4;
        return result;
    }
}