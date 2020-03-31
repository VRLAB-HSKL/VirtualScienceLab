using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using UnityEngine;

public class DataMapper
{
    private Hashtable valueList;

    private List<float> xValueCollection;

    public string[] leftSideElements { get; set; }
    public string[] rightSideElements { get; set; }

    public int positionsCount { get;  set; }

    public void convertReadedDataToHashTable()
    {
        xValueCollection = new List<float>();
        valueList = new Hashtable();
        for (int i = 0; i < positionsCount; i++)
        {
            float x = Convert.ToSingle(leftSideElements[i], CultureInfo.InvariantCulture);
            float y = Convert.ToSingle(rightSideElements[i], CultureInfo.InvariantCulture);
            valueList.Add(x, y);
            xValueCollection.Add(x);
        }
    }

    public float getYValueFromHashTable(float x)
    {
        float yValue = ClosestValue.ClosestTo(xValueCollection, x);
        Debug.Log(yValue);
        return (float)valueList[yValue];
    }

   
    public Vector3[] getVectorPointsFor3DLineRenderer()
    {
        Vector3[] vP = new Vector3[positionsCount];
        for (int i = 0; i < positionsCount; i++)
        {
            float x = Convert.ToSingle(leftSideElements[i], CultureInfo.InvariantCulture);
            float y = Convert.ToSingle(rightSideElements[i], CultureInfo.InvariantCulture);
            float z = 0;
            vP[i] = new Vector3(x, y, z);
        }
        return vP;
    }
}

