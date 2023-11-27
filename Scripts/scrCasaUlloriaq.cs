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
            scriptGC.ativarQuadroAviso("Ulloriaq - Olá visitante! Poderia me ajudar? O meu cachorro perdeu seu brinquedo favorito no meio dos montes de neve que surgiram após a nevasca recente, " + 
            "e não posso deixar as crianças sozinhas sabendo que uma nova tempestade se aproxima. " +
            "Por sorte, tenho uma pá guardada em um baú roxo, e a chave que o abre está do lado de uma das matrioskas. " +
            "Recupere o brinquedo e eu lhe darei a metade de uma das matrioskas.");  
        }

        if (outroGameObject.CompareTag("Player") && scriptGC.bolinha == true) 
        {
            scriptGC.ativarQuadroAviso("Ulloriaq - Você o encontrou!! Obrigada, aqui está a metade da matrioska prometida. Até mais!");
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
