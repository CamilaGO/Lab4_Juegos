using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VolumenControler : MonoBehaviour
{
    private AudioSource sonido;
    public float volumen = 1f;
    // Start is called before the first frame update
    void Start()
    {
        sonido = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        sonido.volume = volumen;
    }

    //Metodo para slider del UI
    public void SetVolume(float nuevoVolumen)
    {
        volumen = nuevoVolumen;
    }
}
