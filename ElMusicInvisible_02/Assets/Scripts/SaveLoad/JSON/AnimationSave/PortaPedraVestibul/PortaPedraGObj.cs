using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortaPedraGObj : MonoBehaviour
{
    TimelineController timeline;

    public int index;
    public bool setActive = true;

    private void Awake()
    {
        timeline = GetComponent<TimelineController>();
    }


    public void SaveIndex(int index)
    {
        
        this.index = index;
       // SaveAnimationsStateJson.SavePortaPedra(this);
    }

    public void SaveBool(bool setActive)
    {
        this.setActive = setActive;
        
    }

    public void EraseJson()
    {
        SaveAnimationsStateJson.SavePortaPedra(this);

    }

    private void OnDisable()
    {
        SaveAnimationsStateJson.SavePortaPedra(this);

    }
    private void OnEnable()
    {
        PortaPedraData portaPedraData = SaveAnimationsStateJson.LoadPortaPedra();
        index = portaPedraData.index;
        setActive = portaPedraData.setActive;
        if ( index == 1)
        timeline.PlayFromTimelines(index);
        gameObject.SetActive(setActive);

    }
}
