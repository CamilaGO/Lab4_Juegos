using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Premio : MonoBehaviour
{
    private Rigidbody rb;
    public Renderer rend;
    public Color cambio;
    public Color original;
    public float force;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rend = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    //Cuando se coloca el mouse sobre el objeto cambia de color
    private void OnMouseEnter()
    {
        Ray myRay = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hitInfo;
        if (Physics.Raycast(myRay, out hitInfo)){
            //rb.AddForce(-hitInfo.normal * force, ForceMode.Impulse);
            GetComponent<AudioSource>().Play();
            rend.material.color = cambio;
        }
          
    }


    // ...regresa a su color original cuando se le quita el mouse
    private void OnMouseExit()
    {
         rend.material.color = original;
        Debug.Log("Saliendo del objeto");
    }

    //Si se le da click al objeto este se mueve
    private void OnMouseDown()
    {
        Debug.Log("Click en el objeto");
        Ray myRay = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hitInfo;
        if (Physics.Raycast(myRay, out hitInfo))
            rb.AddForce(-hitInfo.normal * force, ForceMode.Force);



    }
}
