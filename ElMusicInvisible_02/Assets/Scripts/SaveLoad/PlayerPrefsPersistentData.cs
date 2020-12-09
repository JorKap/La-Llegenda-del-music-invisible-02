using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPrefsPersistentData : MonoBehaviour
{
    public static void SaveData(PlayerManager player)
    {
       
        PlayerPrefs.SetString("name", player.transform.parent.parent.name);
        
    }
   public static PlayerPrefsData LoadData()
    {
      
        string parentName = PlayerPrefs.GetString("name", "StartPosition");

        PlayerPrefsData prefsData = new PlayerPrefsData()
        {
           
            LocationName = parentName
        };

        return prefsData;
    }

   
}
