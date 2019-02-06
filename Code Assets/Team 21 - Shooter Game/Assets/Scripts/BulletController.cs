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
        float angle = transform.position.z;
        transform.Translate(Mathf.Sin(angle) , Mathf.Cos(angle) , 0);

        time += Time.deltaTime;
        if (time >= 30f)
        {
            gameObject.SetActive(false);
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        gameObject.SetActive(false);
    }
}
