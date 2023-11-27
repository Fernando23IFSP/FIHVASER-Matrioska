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
            scriptGC.ativarQuadroAviso("Ukiuk - Ol�, colega novo! Quer uma metade de uma matrioska? Preciso de um favorzinho antes... " +
            "Ent�o, eu estava saindo pra pescar quando uma nevasca come�ou e fez com que um bloco de gelo bloqueasse " +
            "a entrada do meu iglu. H�, em um dos ba�s abaixo, uma picareta, a chave est� ali � frente. Pode liberar a " +
            "passagem enquanto eu tento a sorte na pescaria?");

        }
        if(outroGameObject.CompareTag("Player") && scriptGC.gelo == true) 
        {
            scriptGC.ativarQuadroAviso("Ukiuk - Muito Obrigado!! Como combinamos, aqui est� o que voc� procurava!");
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
