using UnityEngine;
using UnityEngine.UI;

public class Gun : MonoBehaviour
{
    public float damage = 10f;
    public float range = 100f;
    public Camera fpsCam;
    int contador = 0;
    public Text countText;

    // Start is called before the first frame update
    void Start()
    {
        SetCountText();
    }

    // Update is called once per frame
    void Update()
    {
        //Si da click se dispara
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }

    public void Shoot()
    {
        RaycastHit hitInfo;
        if(Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hitInfo, range))
        {
            Debug.Log(hitInfo.transform.name);
            GetComponent<AudioSource>().Play();
            //Evalua si le dispara a un objeto de tipo moneda
            Moneda moneda = hitInfo.transform.GetComponent<Moneda>();
            if(moneda != null)
            {
                //Se llama al metodo de la moneda y se suma el resultado al contador
                int resultado = moneda.TakeDame(damage);
                contador += resultado;
                SetCountText();
                Debug.Log(contador);
            }
        }
    }

    void SetCountText()
    {
        //Se muestra la cantidad de monedas recolectadas
       countText.GetComponent<Text>().text = "Coins: " + contador;
     
    }
}
