using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scrChave : MonoBehaviour
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
            scriptGC.ativarQuadroAviso("Voc� encontrou uma chave! Ela pode ser �til para abrir alguma coisa...");

        }
    }

    public void OnTriggerExit2D(Collider2D outroGameObject)
    {
        if (outroGameObject.CompareTag("Player"))
        {
            scriptGC.desativarQuadroAviso();
            scriptGC.chaveamarela = true;
            scriptGC.adicionarChaves();
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
