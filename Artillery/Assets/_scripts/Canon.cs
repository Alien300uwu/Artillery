using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Canon : MonoBehaviour
{
    [SerializeField] private GameObject BalaPrefab;
    private GameObject puntaCanon;
    private float rotacion;

    private void Start()
    {
        puntaCanon = transform.Find("PuntaCanon").gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        rotacion += Input.GetAxis("Horizontal") * AdministradorJuego.VelocidadRotacion;
        if(rotacion <= 90 && rotacion >= 0)
        {
            transform.eulerAngles = new Vector3(rotacion, 90, 0.0f);
        }

        if (rotacion > 90) rotacion = 90;
        if (rotacion < 0) rotacion = 0;

        if(Input.GetKeyDown(KeyCode.Space))
        {
            GameObject temp = Instantiate(BalaPrefab, puntaCanon.transform.position, transform.rotation);
            Rigidbody tempRB = temp.GetComponent<Rigidbody>();
            Vector3 direccionDisparo = transform.rotation.eulerAngles;
            direccionDisparo.y = 90 - direccionDisparo.x;
            tempRB.velocity = direccionDisparo.normalized * AdministradorJuego.VelocidadBala;

            AdministradorJuego.DisparosPorJuego = AdministradorJuego.DisparosPorJuego - 1;
            Debug.Log($"La cantidad de balas que quedan son = {AdministradorJuego.DisparosPorJuego}");
        }
        if(AdministradorJuego.DisparosPorJuego < 1)
        {
            GameObject.Destroy(puntaCanon);
        }
        
        

    }
}
