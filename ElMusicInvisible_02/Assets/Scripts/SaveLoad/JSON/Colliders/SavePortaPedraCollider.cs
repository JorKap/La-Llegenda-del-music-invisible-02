using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class SavePortaPedraCollider : MonoBehaviour
{
    public static void Save(PortaPedraCollider _data)
    {
        string jsonPath = Application.persistentDataPath + "/portaPedraCollider.json";
        PortaPedraColliderData data = new PortaPedraColliderData(_data);
        string json = JsonUtility.ToJson(data);
        File.WriteAllText(jsonPath, json);
        Debug.Log("Save " + json);
    }

    public static PortaPedraColliderData Load()
    {
        string jsonPath = Application.persistentDataPath + "/portaPedraCollider.json";
        if (File.Exists(jsonPath))
        {
            string jsonRead = File.ReadAllText(jsonPath);
            PortaPedraColliderData data = JsonUtility.FromJson<PortaPedraColliderData>(jsonRead);
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
