using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortaEscala : MonoBehaviour
{
    TimelineController timeline;

    public int index;


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
        SavePortaEscalaJson.Save(this);
    }
    private void OnDisable()
    {
        SavePortaEscalaJson.Save(this);

    }
    private void OnEnable()
    {
        PortaEscalaData portaEscala = SavePortaEscalaJson.Load();
        index = portaEscala.index;

        if (index == 1)
            timeline.PlayFromTimelines(index);


    }
}
