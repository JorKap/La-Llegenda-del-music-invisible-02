using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class SaveAnimationsStateJson
{
    public static void SavePortaEntrada(PortaEntradaGobj portaEntradaGobj)
    {
        string jsonPath = Application.persistentDataPath + "/portaEntrada.json";
        PortaEntradaData data = new PortaEntradaData(portaEntradaGobj);
        string json = JsonUtility.ToJson(data);
        File.WriteAllText(jsonPath, json);
        Debug.Log("Save " + json);
    }

    public static PortaEntradaData LoadPortaEntrada()
    {
        string jsonPath = Application.persistentDataPath + "/portaEntrada.json";
        if (File.Exists(jsonPath))
        {
            string jsonRead = File.ReadAllText(jsonPath);
            PortaEntradaData data = JsonUtility.FromJson<PortaEntradaData>(jsonRead);
            Debug.Log("Load " + jsonRead);
            return data;
        }
        else
        {
            Debug.LogError("Save file not found in" + jsonPath);
            return null;
        }
    }

    //Porta pedra

    public static void SavePortaPedra(PortaPedraGObj _data)
    {
        string jsonPath = Application.persistentDataPath + "/portaPedra.json";
        PortaPedraData data = new PortaPedraData(_data);
        string json = JsonUtility.ToJson(data);
        File.WriteAllText(jsonPath, json);
        Debug.Log("Save " + json);
    }

    public static PortaPedraData LoadPortaPedra()
    {
        string jsonPath = Application.persistentDataPath + "/portaPedra.json";
        if (File.Exists(jsonPath))
        {
            string jsonRead = File.ReadAllText(jsonPath);
            PortaPedraData data = JsonUtility.FromJson<PortaPedraData>(jsonRead);
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
