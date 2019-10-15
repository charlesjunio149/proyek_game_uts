using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    GameObject CanvasInfo;

    void Awake()
    {
        CanvasInfo = GameObject.Find("CanvasInfo");
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Destroy(gameObject);
            CanvasInfo.GetComponent<CanvasInfo>().tambahKoin();
        }
    }
}
