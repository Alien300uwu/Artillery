using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Canon : MonoBehaviour
{
    public static bool Bloqueado;

    public AudioClip clipDisparo;
    private GameObject SonidoDisparo;
    private AudioSource SourceDisparo;

    [SerializeField] private GameObject BalaPrefab;
    public GameObject PartiulasDisparo;
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
        SonidoDisparo = GameObject.Find("SonidoDisparo");
        SourceDisparo = SonidoDisparo.GetComponent<AudioSource>();
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

        if (Input.GetKeyDown(KeyCode.Space) && !Bloqueado)
        {
            GameObject temp = Instantiate(BalaPrefab, puntaCanon.transform.position, transform.rotation);
            Rigidbody tempRB = temp.GetComponent<Rigidbody>();
            SeguirCamara.objetivo = temp;
            Vector3 direccionDisparo = transform.rotation.eulerAngles;
            direccionDisparo.y = 90 - direccionDisparo.x;
            Vector3 direccionParticulas = new Vector3(-90 + direccionDisparo.x, 90, 0); 
            GameObject PartiulasDisparos = Instantiate(PartiulasDisparo, puntaCanon.transform.position, Quaternion.Euler(direccionParticulas), transform);
            tempRB.velocity = direccionDisparo.normalized * _velocidadBalas;
            SourceDisparo.Play();
            Bloqueado = true;


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
