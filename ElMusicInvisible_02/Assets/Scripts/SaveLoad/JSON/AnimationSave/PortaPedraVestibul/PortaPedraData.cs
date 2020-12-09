using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PortaPedraData
{

    public int index;
    public bool setActive;

    public PortaPedraData(PortaPedraGObj portaPedraGobj)
    {

        index = portaPedraGobj.index;
        setActive = portaPedraGobj.setActive;

    }
}
