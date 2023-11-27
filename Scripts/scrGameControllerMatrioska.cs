using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scrGameControllerMatrioska: MonoBehaviour
{
    [Header("GameObjects")]
    [SerializeField] GameObject pnlQuadroAviso;
    [SerializeField] GameObject pnlVencer;
    [SerializeField] GameObject HUD;
    [SerializeField] TMP_Text Txt_Chave_Amarela;
    [SerializeField] TMP_Text Txt_Chave_Roxa;
    [SerializeField] TMP_Text Txt_Chave_Rosa;
    [SerializeField] TMP_Text Txt_Bolinha;
    [SerializeField] TMP_Text Txt_Picareta;
    [SerializeField] TMP_Text Txt_Pa;
    [SerializeField] TMP_Text txtQuadroAviso;
    public bool picareta;
    public bool pa;
    public bool gelo;
    public bool chaveamarela;
    public bool chaveroxa;
    public bool chaverosa;
    public bool matrioskavermelha;
    public bool matrioskaAzul;
    public bool matrioskaverde;
    public bool MVerdeCompleta = false;
    public bool MAzulCompleta = false;
    public bool MVermelhaCompleta = false;
    public bool bolinha;
    public bool terminou = false;

    // Start is called before the first frame update
    void Start()
    {
        desativarQuadroAviso();
    }

    public void ativarQuadroAviso(string msg) 
    {
        txtQuadroAviso.SetText(msg);
        pnlQuadroAviso.SetActive(true);
    }

    public void desativarQuadroAviso()
    {
        pnlQuadroAviso.SetActive(false);
    }

    public void adicionarChaves()
    {
        if (chaveamarela == true) { Txt_Chave_Amarela.SetText("1/1"); } else { Txt_Chave_Amarela.SetText("0/1"); }
        if (chaveroxa == true) { Txt_Chave_Roxa.SetText("1/1"); } else { Txt_Chave_Roxa.SetText("0/1"); }
        if (chaverosa == true) { Txt_Chave_Rosa.SetText("1/1"); } else { Txt_Chave_Rosa.SetText("0/1"); }
    }

    public void adicionarObjetos() 
    {
        if(bolinha == true) { Txt_Bolinha.SetText("1/1"); } else { Txt_Bolinha.SetText("0/1"); }
        if (pa == true) { Txt_Pa.SetText("1/1"); } else { Txt_Pa.SetText("0/1"); }
        if (picareta == true) { Txt_Picareta.SetText("1/1"); } else { Txt_Picareta.SetText("0/1"); }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

