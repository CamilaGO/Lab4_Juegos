using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    public GameObject player;
    public GameObject currPlayer;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Ray myRay = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hitInfo;

        if (Input.GetMouseButton(0))
            if (Physics.Raycast(myRay, out hitInfo))
            {
                hitInfo.collider.GetComponent<MeshRenderer>().material.color = Color.blue;
            }

        if (Input.GetKeyDown(KeyCode.Return))
            if (player && !currPlayer)
                currPlayer = Instantiate(player, new Vector3(3, 5, 0), Quaternion.identity);

    }

}
