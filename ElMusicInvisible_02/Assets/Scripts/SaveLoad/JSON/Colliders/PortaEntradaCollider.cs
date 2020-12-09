using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortaEntradaCollider : MonoBehaviour
{
    public bool enable;
    public Collider col;
    // Start is called before the first frame update
    

    public void SetEnabled(bool enable)
    {
        this.enable = enable;
    }

    public void EraseJson()
    {
        SaveCollidersState.SavePortaEntrada(this);

    }

    private void OnDisable()
    {
        SaveCollidersState.SavePortaEntrada(this);
    }

    private void OnEnable()
    {
        PortaEntradaColliderData data = SaveCollidersState.LoadPortaEntrada();
        
        enable = data.enable;
        col.enabled = enable;
    }
}
