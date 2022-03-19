using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Canon : MonoBehaviour
{
    [SerializeField] private GameObject BalaPrefab;
    private GameObject puntaCanon;
    private float rotacion;


    //Opcional
    public int cantidadDeBalas = AdministradorJuego.DisparosPorJuego;
    private int _CantidadDeBalas
    {
        get { return cantidadDeBalas; }
        set 
        {
            cantidadDeBalas = value;
        }
    }

    //Opcional
    public int VelocidadBalas = AdministradorJuego.VelocidadBala;
    private int _velocidadBalas
    {
        get { return VelocidadBalas; }
        set 
        {
            VelocidadBalas = value;
        }
    }
    



private void Start()
    {
        puntaCanon = transform.Find("PuntaCanon").gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        rotacion += Input.GetAxis("Horizontal") * AdministradorJuego.VelocidadRotacion;
        if (rotacion <= 90 && rotacion >= 0)
        {
            transform.eulerAngles = new Vector3(rotacion, 90, 0.0f);
        }

        if (rotacion > 90) rotacion = 90;
        if (rotacion < 0) rotacion = 0;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject temp = Instantiate(BalaPrefab, puntaCanon.transform.position, transform.rotation);
            Rigidbody tempRB = temp.GetComponent<Rigidbody>();
            Vector3 direccionDisparo = transform.rotation.eulerAngles;
            direccionDisparo.y = 90 - direccionDisparo.x;
            tempRB.velocity = direccionDisparo.normalized * _velocidadBalas;


            //Esto reduce la cantidad de balas
            _CantidadDeBalas = _CantidadDeBalas - 1;
            Debug.Log($"La cantidad de balas que quedan son = {_CantidadDeBalas}");
        }

        //Esto detiene el canon
        if (_CantidadDeBalas < 1)
        {
            GameObject.Destroy(puntaCanon);
        }


        Debug.Log(_CantidadDeBalas);
        Debug.Log(_velocidadBalas);
    }
}
