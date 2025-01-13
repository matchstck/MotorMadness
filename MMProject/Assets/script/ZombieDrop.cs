using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class ZombieDrop : MonoBehaviour
{
    public GameObject dropItem;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Bullet"))
        {
            Instantiate(dropItem, transform.position, transform.rotation);
            Destroy(gameObject);
        }

    }
}
