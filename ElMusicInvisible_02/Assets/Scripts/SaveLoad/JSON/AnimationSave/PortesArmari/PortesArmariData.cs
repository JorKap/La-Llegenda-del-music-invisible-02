using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PortesArmariData 
{
    public int index;

    public PortesArmariData(PortesArmari portesArmari)
    {
        index = portesArmari.index;
    }
}
