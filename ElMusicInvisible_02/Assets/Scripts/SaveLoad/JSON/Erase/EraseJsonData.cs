using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EraseJsonData : MonoBehaviour
{
    public PlayerManager playerManager;
    public static EraseJsonData instance;

    public List<Reaccio> esborrarJsonInfo = new List<Reaccio>();

    public PortaEntradaGobj entradaGobj;
    public PortaEscala portaEscala;
    public PortaPedraGObj portaPedra;
    public PortaSalaPiano portaSalaPiano;
    public ElDiableCard diableCard;
    public LaLlunaCarta llunaCarta;
    public SacerdotessaCarta sacerdotessa;
    public LaTempransaCarta tempransaCarta;
    public PortaEntradaCollider entradaCollider;
    public PortaPedraCollider portaPedraCollider;

    private TotesCondicionsScriptable condicionsScriptable;

    private void Awake()
    {
        condicionsScriptable = Resources.Load<TotesCondicionsScriptable>("TotesCondicions");
        instance = this;
    }

    public void EsborrarJsonData()
    {
        foreach (Reaccio reaccio in esborrarJsonInfo)
        {
            reaccio.Reacciona();
        }
        entradaGobj.EraseJson();
        portaEscala.EraseJson();
        portaPedra.EraseJson();
        portaSalaPiano.EraseJson();
        diableCard.EraseJson();
        llunaCarta.EraseJson();
        sacerdotessa.EraseJson();
        tempransaCarta.EraseJson();
        entradaCollider.EraseJson();
        portaPedraCollider.EraseJson();

    }
    public void ErasePlayerPrefsData()
    {
        playerManager.ErasePrefsData();
    }
    public void EraseStateConditions()
    {
        foreach (Condicio condicio in condicionsScriptable.condicions)
        {
            condicio.estat = false;
        }
    }
   
}
