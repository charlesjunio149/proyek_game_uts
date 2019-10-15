using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

 

public class Canvas1 : MonoBehaviour
{
    public Text Text_koin;
    public float time=0;
    [SerializeField]
    Text txttime; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void tambahKoin()
    {
        int koin = int.Parse(Text_koin.text);
        koin++;
        Text_koin.text = koin + "";

        //if (koin >= 5)
        //{
        //    Pohon.SetActive(true);
        //}
    }



    // Update is called once per frame
    void Update()
    {
        time+=Time.deltaTime;
        txttime.text=((int)time).ToString();
    }
}
