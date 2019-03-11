using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour {
    float time = 0f;
    public float bulletSpeed = 1f;
    public int damage;
    Vector2 direction = new Vector2(0, 0);
    Quaternion rot = new Quaternion(0, 0, 0, 1);


    public Vector3 MoveDir;

    void OnEnable()
    {
        time = 0f;

        Vector3 mousePosition = Input.mousePosition;
        mousePosition = Camera.main.ScreenToWorldPoint(new Vector3(mousePosition.x, mousePosition.y, 10f));
        mousePosition.z = 0;

        MoveDir =  (mousePosition - this.transform.position).normalized;
    }

    void Update () {
        transform.Translate(MoveDir*bulletSpeed);

        time += Time.deltaTime;
        if (time >= 30f)
        {
            gameObject.SetActive(false);
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Bullet Collision:" + collision.gameObject.name);
        if (!collision.gameObject.CompareTag("Player"))
        {
            gameObject.SetActive(false);
        }
    }
}
