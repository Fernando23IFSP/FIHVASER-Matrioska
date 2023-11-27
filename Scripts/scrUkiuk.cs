using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scrUkiuk : MonoBehaviour
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
        if (outroGameObject.CompareTag("Player"))
        {
            scriptGC.ativarQuadroAviso("Ukiuk - Olá, colega novo! Quer uma metade de uma matrioska? Preciso de um favorzinho antes... " +
            "Então, eu estava saindo pra pescar quando uma nevasca começou e fez com que um bloco de gelo bloqueasse " +
            "a entrada do meu iglu. Há, em um dos baús abaixo, uma picareta, a chave está ali à frente. Pode liberar a " +
            "passagem enquanto eu tento a sorte na pescaria?");

        }
        if(outroGameObject.CompareTag("Player") && scriptGC.gelo == true) 
        {
            scriptGC.ativarQuadroAviso("Ukiuk - Muito Obrigado!! Como combinamos, aqui está o que você procurava!");
            scriptGC.matrioskaAzul = true;
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
