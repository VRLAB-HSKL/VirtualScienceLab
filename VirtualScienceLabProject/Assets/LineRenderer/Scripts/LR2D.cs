using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using UnityEditor;
using UnityEngine;

[RequireComponent(typeof(LineRenderer))]
public class LR2D : MonoBehaviour
{
    private LineRenderer _LR;
    private DataWrapper dataWrapper;

    private void Awake()
    {
        dataWrapper = GameObject.Find("LR").GetComponent<DataWrapper>();
        _LR = GetComponent<LineRenderer>();
       
    }

    // Start is called before the first frame update
    void Start()
    {
        dataWrapper.ReadExternalDataFile();
        showLine2D();  
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void showLine2D()
    {
        Vector3[] vP = dataWrapper.get3DimensionalData();
        int count = dataWrapper.getPositionsCount();
        _LR.positionCount = count;
        _LR.SetPositions(vP);
    }
}
