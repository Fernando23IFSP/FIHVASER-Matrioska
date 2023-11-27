using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scrCasaUlloriq : MonoBehaviour
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

        if (outroGameObject.CompareTag("Player") && scriptGC.bolinha != true) 
        {
            scriptGC.ativarQuadroAviso("Ulloriaq - Ol� visitante! Poderia me ajudar? O meu cachorro perdeu seu brinquedo favorito no meio dos montes de neve que surgiram ap�s a nevasca recente, " + 
            "e n�o posso deixar as crian�as sozinhas sabendo que uma nova tempestade se aproxima. " +
            "Por sorte, tenho uma p� guardada em um ba� roxo, e a chave que o abre est� do lado de uma das matrioskas. " +
            "Recupere o brinquedo e eu lhe darei a metade de uma das matrioskas.");  
        }

        if (outroGameObject.CompareTag("Player") && scriptGC.bolinha == true) 
        {
            scriptGC.ativarQuadroAviso("Ulloriaq - Voc� o encontrou!! Obrigada, aqui est� a metade da matrioska prometida. At� mais!");
            scriptGC.matrioskaverde = true;
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
