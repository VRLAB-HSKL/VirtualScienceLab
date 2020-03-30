using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataWrapper : MonoBehaviour
{

    public bool specificFile = false;

    private DataMapper2D dataMapper;
    private ReadExternalData readExternalData;

    [ConditionalHide("specificFile", true)]
    public string fileName;


    // Wird beim initialisieren des Skripts aufgerufen!!!!
    private void Awake()
    {
        dataMapper = new DataMapper2D();
        readExternalData = new ReadExternalData();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private string ReadExternalDataPath()
    {
        string path;
        Debug.Log("Test Data: " + fileName + "FlagStatus: " + specificFile);

        if (specificFile)
        {
            path = readExternalData.ReadSpecificExternalDataFile(fileName); 
        }
        else
        {
            path = readExternalData.ReadDefaultExternalDataFile(); 
        }
        Debug.Log("FileName: " + path);
        return path;
    }

    public void ReadExternalDataFile()
    {
        string _path = ReadExternalDataPath();
        readExternalData.ReadDataTwoDimensional(_path);
        Debug.Log(_path);
        initRawData();
    }

    
    private void initRawData()
    {
        dataMapper.leftSideElements = readExternalData.leftSideElements;
        dataMapper.rightSideElements = readExternalData.rightSideElements;
    }
    
    public Vector3[] get3DimensionalData()
    {
        Vector3[] vP = dataMapper.getVectorPointsFor3DLineRenderer();
        return vP;
    }

    public Vector2[] get2DimensionalData()
    {
        return dataMapper.getVectorPointsFor2DLineRenderer();
    }

    public int getPositionsCount()
    {
        int count = dataMapper.positionsCount;
        return count;
    }
}
