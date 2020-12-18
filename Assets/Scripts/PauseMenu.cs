using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject menu;
    // Start is called before the first frame update

    public void Quit()
    {
        Application.Quit();
    }
    // Update is called once per frame
    void Update()
    {
        //if (!isLocalPlayer) return;
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (menu.activeSelf == true)
            {
                menu.SetActive(false);
            }
            else
            {
                menu.SetActive(true);
            }
        }
        if (menu.activeSelf == true)
        {
            if (Input.GetKeyDown(KeyCode.Q))
            {
                Quit();
            }
        }
    }
}
