using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scrBauRosa : MonoBehaviour
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
        if (outroGameObject.CompareTag("Player") && scriptGC.chaverosa == false)
        {
            scriptGC.ativarQuadroAviso("Aqui está o baú, agora só falta a chave...");

        }
        if (outroGameObject.CompareTag("Player") && scriptGC.chaverosa == true)
        {
            scriptGC.ativarQuadroAviso("Você abriu o baú e liberou uma metade de uma matrioska!");
            scriptGC.matrioskavermelha = true;

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
