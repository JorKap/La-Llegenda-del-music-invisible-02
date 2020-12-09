using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class SavePortesArmariJson 
{
    public static void Save(PortesArmari portesArmari)
    {
        string jsonPath = Application.persistentDataPath + "/portesArmari.json";
        PortesArmariData data = new PortesArmariData(portesArmari);
        string json = JsonUtility.ToJson(data);
        File.WriteAllText(jsonPath, json);
        Debug.Log("Save " + json);
    }

    public static PortesArmariData Load()
    {
        string jsonPath = Application.persistentDataPath + "/portesArmari.json";
        if (File.Exists(jsonPath))
        {
            string jsonRead = File.ReadAllText(jsonPath);
            PortesArmariData data = JsonUtility.FromJson<PortesArmariData>(jsonRead);
            Debug.Log("Load " + jsonRead);
            return data;
        }
        else
        {
            Debug.LogError("Save file not found in" + jsonPath);
            return null;
        }
    }
}
