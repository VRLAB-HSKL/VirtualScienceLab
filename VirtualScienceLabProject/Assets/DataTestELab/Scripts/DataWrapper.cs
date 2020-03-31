using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataWrapper : MonoBehaviour
{

    public bool specificFile = false;

    private DataMapper dataMapper;
    private ReadExternalData readExternalData;

    [ConditionalHide("specificFile", true)]
    public string fileName;


    // Wird beim initialisieren des Skripts aufgerufen!!!!
    private void Awake()
    {
        dataMapper = new DataMapper();
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
        if (specificFile)
        {
            path = readExternalData.ReadSpecificExternalDataFile(fileName); 
        }
        else
        {
            path = readExternalData.ReadDefaultExternalDataFile(); 
        }
        return path;
    }

    public void ReadExternalDataFile()
    {
        string _path = ReadExternalDataPath();
        readExternalData.ReadDataTwoDimensional(_path);
        initRawData();
    }

    
    private void initRawData()
    {
        dataMapper.leftSideElements = readExternalData.leftSideElements;
        dataMapper.rightSideElements = readExternalData.rightSideElements;
        dataMapper.positionsCount = readExternalData.positionsCount;
    }
    
    public Vector3[] get3DimensionalData()
    {  
        return dataMapper.getVectorPointsFor3DLineRenderer();
    }

    public int getPositionsCount()
    {  
        return dataMapper.positionsCount;
    }

    public float getYValueFromHashTable(float x)
    {
        return dataMapper.getYValueFromHashTable(x);
    }

    public void fillHashTableWithInterpolateValues()
    {
        dataMapper.convertReadedDataToHashTable();
    }
}
