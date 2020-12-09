using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;


public class PortaEntradaGobj : MonoBehaviour
{
    TimelineController timeline;
  
    public int index ;


    private void Awake()
    {
            timeline = GetComponent<TimelineController>();
    }


    public void SaveIndex(int index)
    {
        this.index = index;
    }

    public void EraseJson()
    {
        SaveAnimationsStateJson.SavePortaEntrada(this);
       

    }
    private void OnDisable()
    {
        SaveAnimationsStateJson.SavePortaEntrada(this);
        
    }

    private void OnEnable()
    {
        PortaEntradaData portaEntradaData = SaveAnimationsStateJson.LoadPortaEntrada();
        index = portaEntradaData.index;
        if (timeline != null && index == 1)
            timeline.PlayFromTimelines(index);

    }

   
}
