using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using System;

public class startbutton : MonoBehaviour
{
    public TMP_InputField p1N;
    public TMP_InputField p2N;
    public TMP_InputField Health;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void setVariables()
    {
        variable.vPasser.playerName1 = p1N.text;
        variable.vPasser.playerName2 = p2N.text;
        variable.vPasser.Health = System.Convert.ToInt32(Health.text);
        SceneManager.LoadScene(2);
    }
}
