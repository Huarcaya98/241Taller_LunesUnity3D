using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spw_Vida : MonoBehaviour
{
    public GameObject coinPrefab_01;
    //public GameObject coinPrefab_02;
    public float timer;
    public float maxTimer;

    void Update()
    {
        Shoot();
    }

    void Shoot()
    {
        timer += Time.deltaTime;
        if (timer >= maxTimer)
        {
            GameObject obj = Instantiate(coinPrefab_01);
            obj.transform.position = transform.position;
            timer = 0;
        }
    }
}
