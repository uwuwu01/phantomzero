using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class variable : MonoBehaviour
{
   public static variable vPasser;
    public string playerName1;
    public string playerName2;
    public int Health;

    public int winner;

    

    private void Awake()
    {
        if (vPasser == null)
        {
            vPasser = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
