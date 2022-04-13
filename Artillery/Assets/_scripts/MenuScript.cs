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
    public void ContinuarJuego()
    {
        canvasMenu.SetActive(false);
    }
    public void VolverAlMenuInicial()
    {
        SceneManager.LoadScene(0);
    }
    public void SiguienteNivel()
    {
        var siguienteNivel = SceneManager.GetActiveScene().buildIndex + 1;
        if (SceneManager.sceneCountInBuildSettings > siguienteNivel)
        {
            SceneManager.LoadScene(siguienteNivel);
        }
        else
        {
            VolverAlMenuInicial();
        }
    }
    public void ReintentarNivel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }




}