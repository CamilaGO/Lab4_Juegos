using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{
    private bool isPause = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPause) Continue();
            else PauseGame();
        }
    }

    public void PauseGame()
    {
        //Se muestra el panel de pausa
        transform.Find("PanelPause").gameObject.SetActive(true);
        //Se pausan todos los objetos de la escena
        Time.timeScale = 0.0f;
        isPause = true;
    }

    public void Continue()
    {
        //Se quita el menu de pause
        transform.Find("PanelPause").gameObject.SetActive(false);
        //Se vuelven a mover todos los objetos
        Time.timeScale = 1.0f;
        isPause = false;
    }

    public void BackHome(string _newScene)
    {
        SceneManager.LoadScene(_newScene);

    }

}
