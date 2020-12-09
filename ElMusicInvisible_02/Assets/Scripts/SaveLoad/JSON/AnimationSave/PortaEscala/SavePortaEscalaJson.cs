using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class SavePortaEscalaJson 
{
    public static void Save(PortaEscala portaEscala)
    {
        string jsonPath = Application.persistentDataPath + "/portaEscala.json";
        PortaEscalaData data = new PortaEscalaData(portaEscala);
        string json = JsonUtility.ToJson(data);
        File.WriteAllText(jsonPath, json);
        Debug.Log("Save porta escala " + json);
    }

    public static PortaEscalaData Load()
    {
        string jsonPath = Application.persistentDataPath + "/portaEscala.json";
        if (File.Exists(jsonPath))
        {
            string jsonRead = File.ReadAllText(jsonPath);
            PortaEscalaData data = JsonUtility.FromJson<PortaEscalaData>(jsonRead);
            Debug.Log("Load porta escala " + jsonRead);
            return data;
        }
        else
        {
            Debug.LogError("Save file not found in" + jsonPath);
            return null;
        }
    }
}
