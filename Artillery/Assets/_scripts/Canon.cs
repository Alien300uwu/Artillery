using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

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

    public CanonControles canonControls;
    private InputAction apuntar;
    private InputAction modificarFuerza;
    private InputAction disparar;

    public PS4Control Ps4Controller;
    private InputAction apuntarPS;
    private InputAction modificarFuerzaPS;
    private InputAction dispararPS;

    [SerializeField] private Slider _VeloCambio;
   

    private void Awake()
    {
        canonControls = new CanonControles();
    }
    private void OnEnable()
    {
        
        apuntar = canonControls.Canon.Apuntar;
        modificarFuerza = canonControls.Canon.ModificarFuerza;
        disparar = canonControls.Canon.Disparar;
        apuntar.Enable();
        modificarFuerza.Enable();
        disparar.Enable();
        disparar.performed += Disparar;


        apuntarPS = Ps4Controller.Ps4Control.Apuntado;
        modificarFuerzaPS = Ps4Controller.Ps4Control.Fuerza;
        dispararPS = Ps4Controller.Ps4Control.Disparo;
        apuntarPS.Enable();
        modificarFuerzaPS.Enable();
        dispararPS.Enable();
        dispararPS.performed += Disparar;


    }




    //Opcional
    public int cantidadDeBalas = AdministradorJuego.DisparosPorJuego;




    //Opcional
    public int VelocidadBalas = AdministradorJuego.VelocidadBala;




    private void Start()
    {
        puntaCanon = transform.Find("PuntaCanon").gameObject;
        SonidoDisparo = GameObject.Find("SonidoDisparo");
        SourceDisparo = SonidoDisparo.GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {
        rotacion += apuntar.ReadValue<float>() * AdministradorJuego.VelocidadRotacion;
        if (rotacion <= 90 && rotacion >= 0)
        {
            transform.eulerAngles = new Vector3(rotacion, 90, 0.0f);
        }

        if (rotacion > 90) rotacion = 90;
        if (rotacion < 0) rotacion = 0;


        


    }

    private void Disparar(InputAction.CallbackContext context)
    {
        GameObject temp = Instantiate(BalaPrefab, puntaCanon.transform.position, transform.rotation);
        Rigidbody tempRB = temp.GetComponent<Rigidbody>();
        SeguirCamara.objetivo = temp;
        Vector3 direccionDisparo = transform.rotation.eulerAngles;
        direccionDisparo.y = 90 - direccionDisparo.x;
        Vector3 direccionParticulas = new Vector3(-90 + direccionDisparo.x, 90, 0);
        GameObject PartiulasDisparos = Instantiate(PartiulasDisparo, puntaCanon.transform.position, Quaternion.Euler(direccionParticulas), transform);
        tempRB.velocity = direccionDisparo.normalized * VelocidadBalas;
        SourceDisparo.Play();
        Bloqueado = true;


        //Esto reduce la cantidad de balas
        cantidadDeBalas = cantidadDeBalas - 1;
        Debug.Log($"La cantidad de balas que quedan son = {cantidadDeBalas}");




        //Esto detiene el canon
        if (cantidadDeBalas <= 0)
        {
            GameObject.Destroy(puntaCanon);
        }


        Debug.Log(cantidadDeBalas);
        Debug.Log(VelocidadBalas);
    }


   

}
