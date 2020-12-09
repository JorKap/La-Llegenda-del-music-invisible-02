using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortaSalaPiano : MonoBehaviour
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
        SavePortaSalaPianoJson.Save(this);
    }
    private void OnDisable()
    {
        SavePortaSalaPianoJson.Save(this);

    }
    private void OnEnable()
    {
        PortaSalaPianoData portaSalaPiano = SavePortaSalaPianoJson.Load();
        index = portaSalaPiano.index;

        if (index == 1)
            timeline.PlayFromTimelines(index);


    }
}
