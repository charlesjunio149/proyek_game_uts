using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

 

public class Canvas1 : MonoBehaviour
{
    public float time=0;
    [SerializeField]
    Text txttime; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        time+=Time.deltaTime;
        txttime.text=((int)time).ToString();
    }
}
