using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestMono : MonoBehaviour
{
    string myName = "Anna";

    public void PrintDebug()
    {
        Debug.Log("Angeclickt");
    }

    public void PrintmyName(string myNameis)
    {
        Debug.Log("Mein Name ist:" + myNameis);
    }

    public void AddNumbers(int first, int second)
    {
        Debug.Log("Add Numbers: first + second" + (first + second));
    }

    public void MultiplyNumbers(int first, int second, int third)
    {

        Debug.Log("MultiplyNumbers: first * second * third" + (first * second * third));
    }

    public void DivideNumbers(float first, float second, float third)
    {

        Debug.Log("DivideNumbers: frist / second / third" + (first / second / third));
    }

    public void ConcatinateStrings(string myName, string msg)
    {

        Debug.Log("First concatination" + myName + " , " + msg);
    }

    // Use this for initialization
    void Start()
    {
        PrintDebug();
        PrintmyName("anni");
        PrintmyName(myName);
        AddNumbers(1, 2);
        MultiplyNumbers(11, 13, 56);
        DivideNumbers(20.0f, 2.0f, 45.0f);
        ConcatinateStrings("susi", "heute ist ein schöner Tag");

    }

    // Update is called once per frame
    void Update()
    {

    }
}
