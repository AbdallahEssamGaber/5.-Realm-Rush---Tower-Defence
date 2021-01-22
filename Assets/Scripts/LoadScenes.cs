using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class LoadScenes : MonoBehaviour
{
    [SerializeField] List<GameObject> offObjLose = new List<GameObject>();
    [SerializeField] List<GameObject> offObjWin = new List<GameObject>();
    [SerializeField] GameObject spcialCase;
    [SerializeField] GameObject canvasOnTime;

    float delay = 3f;

    public void LoseLoad()
    {
        foreach (GameObject gameObject in offObjLose)
        {
            Destroy(gameObject);
        }

        Invoke("LoadAgain", delay);
    }


    void LoadAgain()
    {
        SceneManager.LoadScene(0);
    }

    public void WinLoad()
    {
        foreach (GameObject gameObject in offObjWin)
        {
            Destroy(gameObject);
        }

        Invoke("Congrats", delay);
        canvasOnTime.SetActive(true);

        Destroy(spcialCase, delay);
    }


    void Congrats()
    {
        SceneManager.LoadScene(0);
    }

}
