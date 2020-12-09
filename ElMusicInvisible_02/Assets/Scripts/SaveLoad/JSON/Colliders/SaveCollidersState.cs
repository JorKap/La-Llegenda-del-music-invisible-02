using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class SaveCollidersState
{
    public static void SavePortaEntrada(PortaEntradaCollider _data)
    {
        string jsonPath = Application.persistentDataPath + "/portaEntradaCollider.json";
        PortaEntradaColliderData data = new PortaEntradaColliderData(_data);
        string json = JsonUtility.ToJson(data);
        File.WriteAllText(jsonPath, json);
        Debug.Log("Save " + json);
    }

    public static PortaEntradaColliderData LoadPortaEntrada()
    {
        string jsonPath = Application.persistentDataPath + "/portaEntradaCollider.json";
        if (File.Exists(jsonPath))
        {
            string jsonRead = File.ReadAllText(jsonPath);
            PortaEntradaColliderData data = JsonUtility.FromJson<PortaEntradaColliderData>(jsonRead);
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
