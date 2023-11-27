using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scrMVermelha2 : MonoBehaviour
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
        if (outroGameObject.CompareTag("Player") && scriptGC.matrioskavermelha != true)
        {
            scriptGC.ativarQuadroAviso("Esta matrioska completa deve ser linda...");
            

        }
        if (outroGameObject.CompareTag("Player") && scriptGC.matrioskavermelha == true)
        {
            scriptGC.ativarQuadroAviso("Agora posso completar ela!");
            GetComponent<AudioSource>().Play();
            matrioskas[0].transform.position = new Vector3(- 9.08f, 4.68f,0);
            scriptGC.MVermelhaCompleta = true;

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
