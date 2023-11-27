using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scrBauRoxo : MonoBehaviour
{
    [SerializeField] GameObject controle;
    scrGameControllerMatrioska scriptGC;
    // Start is called before the first frame update
    void Start()
    {
        scriptGC = controle.GetComponent<scrGameControllerMatrioska>();
    }

    public void OnTriggerEnter2D(Collider2D outroGameObject)
    {
        if (outroGameObject.CompareTag("Player") && scriptGC.chaveroxa == false)
        {
            scriptGC.ativarQuadroAviso("Aqui está o baú, agora só falta a chave...");

        }
        if (outroGameObject.CompareTag("Player") && scriptGC.chaveroxa == true)
        {
            scriptGC.ativarQuadroAviso("Você abriu o baú e liberou a pá!");
            scriptGC.pa = true;
            scriptGC.adicionarObjetos();

        }
    }

    public void OnTriggerExit2D(Collider2D outroGameObject)
    {
        if (outroGameObject.CompareTag("Player"))
        {
            scriptGC.desativarQuadroAviso();
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
