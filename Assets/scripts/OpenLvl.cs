using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class OpenLvl : MonoBehaviour
{
    public Button but;

    public void Start()
    {
        Button btn = but.GetComponent<Button>();
        btn.onClick.AddListener(task);
    }
    public void task() //³������� �������� �����
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

}


