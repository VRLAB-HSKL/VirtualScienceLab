using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;

public class DataMapper2D
{
    private float x;
    private float y;

    //private ArrayList valueList;
    private Hashtable valueList;

    public string[] leftSideElements { get; set; }
    public string[] rightSideElements { get; set; }

    public int positionsCount { get; private set; }

    float[,] resultArray;

    public void initResultArray(int elemCount)
    {
        resultArray = new float[elemCount,elemCount];
    }

    public void convertReadedDataToHashTable()
    {
        for (int i = 0; i < resultArray.Length; i++)
        {
            Debug.Log("First_Array - Element [" + i + "] :" + leftSideElements[i]);
            Debug.Log("Last_Array - Element [" + i + "] :" + rightSideElements[i]);

            float x = Convert.ToSingle(leftSideElements[i], CultureInfo.InvariantCulture);
            float y = Convert.ToSingle(rightSideElements[i], CultureInfo.InvariantCulture);
            valueList.Add(x, y);
        }
    }

    public float getYValueFromHashTable(float x)
    {
        return (float) valueList[x];
    }


    public Vector2[] getVectorPointsFor2DLineRenderer()
    {
        positionsCount = leftSideElements.Length;
        Debug.Log("Positions Count: " + positionsCount);
        Vector2[] vP = new Vector2[positionsCount];
        for (int i = 0; i < positionsCount; i++)
        {
            Debug.Log("First_Array - Element [" + i + "] :" + leftSideElements[i]);
            Debug.Log("Last_Array - Element [" + i + "] :" + rightSideElements[i]);

            float x = Convert.ToSingle(leftSideElements[i], CultureInfo.InvariantCulture);
            float y = Convert.ToSingle(rightSideElements[i], CultureInfo.InvariantCulture);
            vP[i] = new Vector2(x, y);
        }

        for (int i = 0; i < positionsCount; i++)
        {
            Debug.Log("vP - Element [" + i + "] :" + vP[i]);
        }
        return vP;
    }

    public Vector3[] getVectorPointsFor3DLineRenderer()
    {
        positionsCount = leftSideElements.Length;
        Debug.Log("Positions Count: " + positionsCount);
        Vector3[] vP = new Vector3[positionsCount];
        for (int i = 0; i < positionsCount; i++)
        {
            Debug.Log("First_Array - Element [" + i + "] :" + leftSideElements[i]);
            Debug.Log("Last_Array - Element [" + i + "] :" + rightSideElements[i]);

            float x = Convert.ToSingle(leftSideElements[i], CultureInfo.InvariantCulture);
            float y = Convert.ToSingle(rightSideElements[i], CultureInfo.InvariantCulture);
            float z = 0;
            vP[i] = new Vector3(x, y, z);
        }

        for (int i = 0; i < positionsCount; i++)
        {
            Debug.Log("vP - Element [" + i + "] :" + vP[i]);
        }
        return vP;
    }

    public void showData()
    {
        
    }
}

