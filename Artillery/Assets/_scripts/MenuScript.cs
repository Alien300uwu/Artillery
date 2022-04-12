using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MenuScript : MonoBehaviour
{
    public GameObject canvasMenu;
    public GameObject MenuOpciones;

    public void inicioJuego()
    {
        SceneManager.LoadScene(1);
    }
    public void quitarJuego()
    {
        Application.Quit();
    }
    public void MostrarOpciones()
    {
        canvasMenu.SetActive(false);
        MenuOpciones.SetActive(true);
    }

    public void MostrarMenuInicial()
    {
        MenuOpciones.SetActive(false);
        canvasMenu.SetActive(true);
    }







}