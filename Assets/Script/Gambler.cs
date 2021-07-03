using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gambler : MonoBehaviour
{
    [SerializeField]
    private int cash;

    public void getcash(int cash)
    {
        this.cash += cash;
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
