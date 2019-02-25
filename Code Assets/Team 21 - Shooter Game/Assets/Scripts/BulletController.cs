using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour {
    float time = 0f;
    public float bulletSpeed = 1f;

    void OnEnable()
    {
        time = 0f;
    }

    void Update () {
        transform.Translate(0 , bulletSpeed, 0);

        time += Time.deltaTime;
        if (time >= 30f)
        {
            gameObject.SetActive(false);
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if(!collision.gameObject.CompareTag("Player"))
        gameObject.SetActive(false);
    }
}
