using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scrFimJogo : MonoBehaviour
{
    [SerializeField] GameObject controle;
    scrGameControllerMatrioska scriptGC;

    // Start is called before the first frame update
    void Start()
    {
        scriptGC = controle.GetComponent<scrGameControllerMatrioska>();
    }

    // Update is called once per frame
    void Update()
    {
        if ((scriptGC.MVermelhaCompleta == true) && (scriptGC.MVerdeCompleta == true) && (scriptGC.MAzulCompleta == true))
        {
            scriptGC.ativarQuadroAviso("Parabéns!! Você completou o jogo!! " +
                "Aperte E para voltar a casa");
            if(Input.GetKeyDown(KeyCode.E))
            {
                Invoke("LoadMenu", 1f);
            }

        }
    }
    void LoadMenu()
    {
        SceneManager.LoadScene("CasaRussia");
    }
}