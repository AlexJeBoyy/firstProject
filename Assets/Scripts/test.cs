using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class test : MonoBehaviour
{

    public int summery;
    void bla(int num1, int num2)
    {
       summery = num1 + num2;
        Debug.Log(summery);
    }
    private void Start()
    {
        bla(2,45);
        bla(6, 2);
    }

    
}
