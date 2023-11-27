using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scrGelo : MonoBehaviour
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
        if (outroGameObject.CompareTag("Player") && scriptGC.picareta == false)
        {
            scriptGC.ativarQuadroAviso("Caramba, que gelo imenso!!! A tempestade foi forte mesmo...");

        }
        if (outroGameObject.CompareTag("Player") && scriptGC.picareta == true)
        {
            scriptGC.ativarQuadroAviso("Agora consigo liberar a passagem!");
            scriptGC.gelo = true;
        }    
    }

    public void OnTriggerExit2D(Collider2D outroGameObject)
    {
        if (outroGameObject.CompareTag("Player"))
        {
            if(scriptGC.picareta == true) 
            {
                Destroy(gameObject);
            }

            scriptGC.desativarQuadroAviso();
            
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
