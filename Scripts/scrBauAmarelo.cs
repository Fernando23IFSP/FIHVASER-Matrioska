using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scrBauAmarelo : MonoBehaviour
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
        if (outroGameObject.CompareTag("Player") && scriptGC.chaveamarela == false)
        {
            scriptGC.ativarQuadroAviso("Aqui est� o ba�, agora s� falta a chave...");

        }
        if (outroGameObject.CompareTag("Player") && scriptGC.chaveamarela == true)
        {
            scriptGC.ativarQuadroAviso("Voc� abriu o ba� e liberou a picareta!");
            scriptGC.picareta = true;
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
