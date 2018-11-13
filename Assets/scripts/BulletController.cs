using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    private Rigidbody2D rb;
    public CircleCollider2D destructionCircle;
    public static GroundController groundController;

    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnCollisionEnter2D(Collision2D coll)
    {

        if (coll.collider.tag == "Ground")
        {
            groundController.DestroyGround(destructionCircle);
            Destroy(gameObject);
        }
    }
}
