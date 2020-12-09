using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class SavePortaSalaPianoJson : MonoBehaviour
{
    public static void Save(PortaSalaPiano portaSalaPiano)
    {
        string jsonPath = Application.persistentDataPath + "/portaSalaPiano.json";
        PortaSalaPianoData data = new PortaSalaPianoData(portaSalaPiano);
        string json = JsonUtility.ToJson(data);
        File.WriteAllText(jsonPath, json);
        Debug.Log("Save " + json);
    }

    public static PortaSalaPianoData Load()
    {
        string jsonPath = Application.persistentDataPath + "/portaSalaPiano.json";
        if (File.Exists(jsonPath))
        {
            string jsonRead = File.ReadAllText(jsonPath);
            PortaSalaPianoData data = JsonUtility.FromJson<PortaSalaPianoData>(jsonRead);
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
