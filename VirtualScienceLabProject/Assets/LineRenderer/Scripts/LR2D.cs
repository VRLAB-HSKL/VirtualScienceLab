using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using UnityEngine;

[RequireComponent(typeof(LineRenderer))]
public class LR2D : MonoBehaviour
{

    private LineRenderer _LR;
    private String _labURL;
    private String _pcURL = @"G:\U3D_HS_Workspaces\VirtualScienceLab\VirtualScienceLabProject\Assets\LineRenderer\Python\myData.csv";
    private String _laptopURL = @"D:\HS-KL-Lab\Workspace\Examples_LineRenderer\Assets\Python\myData.csv";
    // Start is called before the first frame update
    void Start()
    {
        _LR = GetComponent< LineRenderer>();
        read2D();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void read2D ()
    {
        var firstColumn = new List<string>();
        var lastColumn = new List<string>();

        using (var rd = new StreamReader(_pcURL))
        {
            while (!rd.EndOfStream)
            {
                var splits = rd.ReadLine().Split(';');
                firstColumn.Add(splits[0]);
                lastColumn.Add(splits[1]);
            }
        }

        var firstArray = firstColumn.ToArray();
        var lastArray = lastColumn.ToArray();

        foreach (var element in firstArray)
            Debug.Log(element);

        foreach (var element in lastArray)
            Debug.Log(element);

        convertParams(firstArray, lastArray);
    }

    void convertParams(string[] FirstArray, string[] LastArray)
    {
        int positionsCount = FirstArray.Length;
        Debug.Log("Positions Count: " + positionsCount);
        Vector3[] vP = new Vector3[positionsCount];
        for(int i = 0; i < FirstArray.Length; i++)
        {
            Debug.Log("First_Array - Element [" + i +"] :" + FirstArray[i]);
            Debug.Log("Last_Array - Element [" + i + "] :" + LastArray[i]);

            float x = Convert.ToSingle(FirstArray[i], CultureInfo.InvariantCulture);
            float y = Convert.ToSingle(LastArray[i], CultureInfo.InvariantCulture);
            float z = 0;
            vP[i] = new Vector3(x, y, z);
        }
       
        for(int i = 0; i < FirstArray.Length; i++)
        {
            Debug.Log("vP - Element [" + i + "] :" + vP[i]);
        }

        showLine2D(vP, positionsCount);
    }

    void showLine2D(Vector3[] VP, int PositionsCount)
    {
        _LR.positionCount = PositionsCount;
        _LR.SetPositions(VP);
    }
}
