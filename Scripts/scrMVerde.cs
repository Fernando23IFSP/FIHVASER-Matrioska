using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scrMVerde : MonoBehaviour
{
    [SerializeField] GameObject controle;
    scrGameControllerMatrioska scriptGC;
    [SerializeField] GameObject[] matrioskas;

    // Start is called before the first frame update
    void Start()
    {
        scriptGC = controle.GetComponent<scrGameControllerMatrioska>();
    }

    public void OnTriggerEnter2D(Collider2D outroGameObject)
    {
        if (outroGameObject.CompareTag("Player") && scriptGC.matrioskaverde != true)
        {
            scriptGC.ativarQuadroAviso("Esta matrioska completa deve ser linda...");


        }
        if (outroGameObject.CompareTag("Player") && scriptGC.matrioskaverde == true)
        {
            scriptGC.ativarQuadroAviso("Agora posso completar ela!");
            GetComponent<AudioSource>().Play();
            matrioskas[2].transform.position = new Vector3(0.96f, 4.56f, 0);
            scriptGC.MVerdeCompleta = true;

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
