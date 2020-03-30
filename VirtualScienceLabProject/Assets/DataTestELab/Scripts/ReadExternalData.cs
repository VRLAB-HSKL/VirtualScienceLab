using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEditor;
using UnityEngine;

public class ReadExternalData
{
    public string[] leftSideElements { get; private set; }
    public string[] rightSideElements { get; private set; }

    public string ReadDefaultExternalDataFile()
    {
        /* Default lookup Path: "Assets/Resources/" **/
        var readTextFile = Resources.Load<TextAsset>("LoadFiles/myData");
        string path = AssetDatabase.GetAssetPath(readTextFile);
        return path;
    }

    public string ReadSpecificExternalDataFile(string fileName)
    {
        string _pathToFile = "LoadFiles/" + fileName;
        var readTextFile = Resources.Load<TextAsset>(_pathToFile);
        string path = AssetDatabase.GetAssetPath(readTextFile);
        return path;
    }

    public void ReadDataTwoDimensional(string path)
    {
        Debug.Log("External_Path_Reader: " + path);
        string _path = path;
        List<string> firstColumn = new List<string>();
        List<string> lastColumn = new List<string>();

        using (var rd = new StreamReader(_path))
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

        leftSideElements = firstColumn.ToArray();
        rightSideElements = lastColumn.ToArray();
    }
}
