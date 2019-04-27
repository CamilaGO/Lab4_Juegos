using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moneda : MonoBehaviour
{
    public int speed = 50;
    public float health = 10f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(transform.position, Vector3.right, speed * Time.deltaTime);
    }

    /*private void OnMouseDown()
    {
        Ray myRay = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hitInfo;
        if (Physics.Raycast(myRay, out hitInfo))
         Destroy(gameObject);
    }*/

    public int TakeDame(float valor)
    {
        //Recibe un daño y este se le resta a su vida
        int punteo;
        health -= valor;
        if(health <= 0)
        {
            //Si se queda sin vida se suma 1 al contador de la pistola y se destruye este objeto
            punteo = 1;
            Destroy(gameObject);

        }
        else
        {
            //si todavia tiene vida no se suma nada al contador de la pistola
            punteo = 0;
        }
        return punteo;
    }


}
