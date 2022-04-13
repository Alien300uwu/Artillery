using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CantidadBolas : MonoBehaviour
{
    Canon Bolas;
    public Transform TransfomarBolas;
    public TMP_Text CantidadDeBolas;


    int numeroBalas;

    // Start is called before the first frame update
    void Start()
    {
        TransfomarBolas = GameObject.Find("CantidadBolas").transform;
        CantidadDeBolas = TransfomarBolas.GetComponent<TMP_Text>();

        
    }

    // Update is called once per frame
    void Update()
    {
        Bolas = FindObjectOfType<Canon>();
        numeroBalas = Bolas.cantidadDeBalas;
        CantidadDeBolas.text = $"Bolas: {numeroBalas}";
    }
}
