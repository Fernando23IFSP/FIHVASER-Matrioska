using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scrMontesNeveGeral : MonoBehaviour
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
        if (outroGameObject.CompareTag("Player") && scriptGC.pa != true)
        {
            scriptGC.ativarQuadroAviso("Quanta neve!! Uma pá seria bem útil...");
        }

        if (outroGameObject.CompareTag("Player") && scriptGC.pa == true)
        {
            scriptGC.ativarQuadroAviso("Não está aqui, preciso continuar procurando...");
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
