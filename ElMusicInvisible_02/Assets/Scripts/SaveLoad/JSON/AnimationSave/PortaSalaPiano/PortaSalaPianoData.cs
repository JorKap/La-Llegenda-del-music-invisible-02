using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PortaSalaPianoData 
{
    public int index;

    public PortaSalaPianoData(PortaSalaPiano portaSalaPiano)
    {
        index = portaSalaPiano.index;
    }
}
