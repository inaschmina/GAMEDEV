using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    private static PlayerStats instance = null;
    private static readonly object padlock = new object();
    private int live = 3;

    private PlayerStats() { }

    public static PlayerStats GetInstance()
    {
        if(instance == null)
        {
            instance = new PlayerStats();
        }
        return instance;
    }

    public void reduceLive()
    {
        live--;
        Debug.Log("Live: " + live);
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
