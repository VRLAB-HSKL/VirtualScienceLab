using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using UnityEngine;

public class InterpolateLamp : MonoBehaviour
{
    private ReadExternalData reader;

    // Start is called before the first frame update
    void Start()
    {
        //reader = GetComponent<ReadExternalData>();
        //Debug.Log("path to file: " + reader.GetPathToReadExternalData());
        //readData();
    }

    // Update is called once per frame
    void Update()
    {

    }
    /**
    void readData()
    {
        Debug.Log("External_Path_Reader: " + reader.GetPathToReadExternalData());
        string path = reader.GetPathToReadExternalData();
        var firstColumn = new List<string>();
        var lastColumn = new List<string>();

        using (var rd = new StreamReader(path))
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
        Vector2[] vP = new Vector2[positionsCount];
        for (int i = 0; i < FirstArray.Length; i++)
        {
            Debug.Log("First_Array - Element [" + i + "] :" + FirstArray[i]);
            Debug.Log("Last_Array - Element [" + i + "] :" + LastArray[i]);

            float x = Convert.ToSingle(FirstArray[i], CultureInfo.InvariantCulture);
            float y = Convert.ToSingle(LastArray[i], CultureInfo.InvariantCulture);
            vP[i] = new Vector2(x, y);
        }

        for (int i = 0; i < FirstArray.Length; i++)
        {
            Debug.Log("vP - Element [" + i + "] :" + vP[i]);
        }
    }

    public double getInterpolateY(double x)
    {
        double y = x + 0.1;
        //ToDo return the interpolate y

        return y;
    }

    **/
}
