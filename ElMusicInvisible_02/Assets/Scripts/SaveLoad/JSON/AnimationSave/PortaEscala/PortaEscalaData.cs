using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PortaEscalaData
{
    public int index;

    public PortaEscalaData(PortaEscala portaEscala)
    {
        index = portaEscala.index;
    }
}
