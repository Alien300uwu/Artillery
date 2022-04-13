using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdministradorJuego : MonoBehaviour
{
   

    public static AdministradorJuego SingletonAdministradorJuego;
    public static int VelocidadBala = 50;
    public static int DisparosPorJuego = 10;
    public static float VelocidadRotacion = 1;

    Canon Bolas;

    public GameObject CanvasGanar;
    public GameObject CanvasPerder;
      
    private void Awake()
    {
        if (SingletonAdministradorJuego = null)
        {
            SingletonAdministradorJuego = this;
        }
        else
        {
            Debug.LogError("Ya existe una instancia de esta clase");
        }
    }

    private void Start()
    {

       
        

    }
    public void Update()
    {
        Bolas = FindObjectOfType<Canon>();
        Debug.Log(Bolas.cantidadDeBalas);

 
        if(Bolas.cantidadDeBalas <= 0)
        {
            PerderJuego();
        }
    }

    public void PerderJuego()
    {
        CanvasPerder.SetActive(true);
    }
    public void GanarJuego()
    {
        CanvasGanar.SetActive(true);
    }


    


}
