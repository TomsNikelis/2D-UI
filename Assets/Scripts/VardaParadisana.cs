using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VardaParadisana : MonoBehaviour
{
    string teksts;
    public GameObject ievadesLauks;
    public GameObject tekstaAttelosana;

    public void uzglabatTekstu()
    {
        teksts = ievadesLauks.GetComponent<Text>().text;
        tekstaAttelosana.GetComponent<Text>().text = "Sveiks" + teksts;
    }
}
