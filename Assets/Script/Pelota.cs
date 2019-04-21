using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pelota : MonoBehaviour
{
    public float force = 0;
    public GameObject cubo;
    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (rb && Input.GetButtonDown("Jump"))
            rb.AddForce(0, force, 0, ForceMode.Impulse);

        RaycastHit hitInfo;

        if (Physics.Raycast(transform.position, Vector3.down, out hitInfo, 2))
        {
            /*si si pegó el raycast, se cambia el color de la pelota
            GetComponent<MeshRenderer>().material.color = Color.red;*/
            //si pego en el plano se cambia el color de este
            if (hitInfo.collider.gameObject.CompareTag("Plano"))
                hitInfo.collider.GetComponent<MeshRenderer>().material.color = Color.green;

        }
        Debug.DrawRay(transform.position, Vector3.down*2, Color.red);
    }

    private void FixedUpdate()
    {
        //rb.AddForce(Input.GetAxis("Horizontal") * force, 0, Input.GetAxis("Vertical") * force);
    }

    private void OnMouseDown()
    {
        Ray myRay = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hitInfo;
        if (Physics.Raycast(myRay, out hitInfo))
            rb.AddForce(-hitInfo.normal * force, ForceMode.Impulse);
            //Destroy(gameObject);

    }
}
