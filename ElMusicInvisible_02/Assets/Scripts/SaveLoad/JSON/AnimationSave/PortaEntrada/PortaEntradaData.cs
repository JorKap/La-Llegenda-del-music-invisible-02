using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

[System.Serializable]
public class PortaEntradaData 
{
    
    public int index;

    public PortaEntradaData(PortaEntradaGobj portaEntradaGobj)
    {
       
        index = portaEntradaGobj.index;
        
    }
}
