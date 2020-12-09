using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortesArmari : MonoBehaviour
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

    

    private void OnDisable()
    {
        SavePortesArmariJson.Save(this);

    }
    private void OnEnable()
    {
        PortesArmariData portesArmari = SavePortesArmariJson.Load();
        index = portesArmari.index;
       
        if (index == 1)
            timeline.PlayFromTimelines(index);
       

    }
}
