using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEditor;
using UnityEngine;

public class ReadExternalData : MonoBehaviour
{
    
    public bool specificFileName = false;

    [ConditionalHide("specificFileName", true)]
    public string fileName;

    
    public string GetPathToReadExternalData()
    {
        string _pathToExternalDataFile;

        if (specificFileName)
        {
            _pathToExternalDataFile =  ReadSpecificExternalDataFile();
            return _pathToExternalDataFile;
        } else {
            _pathToExternalDataFile = ReadDefaultExternalDataFile();
            return _pathToExternalDataFile;
        }

    }


    private string ReadDefaultExternalDataFile()
    {
        /* Default lookup Path: "Assets/Resources/" **/
        var readTextFile = Resources.Load<TextAsset>("LoadFiles/myData");
        string path = AssetDatabase.GetAssetPath(readTextFile);
        return path;
    }

    private string ReadSpecificExternalDataFile()
    {
        string _pathToFile = "LoadFiles/" + fileName;
        var readTextFile = Resources.Load<TextAsset>(_pathToFile);
        string path = AssetDatabase.GetAssetPath(readTextFile);
        return path;
    }


}
