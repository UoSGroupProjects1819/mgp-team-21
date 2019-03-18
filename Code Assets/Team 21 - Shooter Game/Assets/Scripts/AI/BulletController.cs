using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour {
    float time = 0f;
    public float bulletSpeed = 1f;
    public int damage;
    public Vector3 MoveDir;
    public GameObject shooter;

    private void Start()
    {
        shooter = gameObject; //should hopefully stop compiler complaining
    }
    void OnEnable()
    {
        time = 0f;
        if (shooter.CompareTag("Player"))
        {
            Vector3 mousePosition = Input.mousePosition;
            mousePosition = Camera.main.ScreenToWorldPoint(new Vector3(mousePosition.x, mousePosition.y, 10f));
            mousePosition.z = 0;
            MoveDir = (mousePosition - this.transform.position).normalized;
        }
        else
        {
            float ShotX = shooter.GetComponent<Blackboard>().GetFloat("ShotX");
            float ShotY = shooter.GetComponent<Blackboard>().GetFloat("ShotY");
            MoveDir = new Vector3(ShotX, ShotY);
        }
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
        if (collision.gameObject.name != shooter.name)
        {
            gameObject.SetActive(false);
        }
    }
}
