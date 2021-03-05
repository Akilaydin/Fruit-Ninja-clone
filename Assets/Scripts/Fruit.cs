using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fruit : MonoBehaviour
{
    [SerializeField]
    private GameObject slicedFruitPrefab;
    [SerializeField]
    private float throwForce = 15f;
    private Rigidbody2D rb;

    private void Start()
    {
        Destroy(gameObject,10f);
        rb = GetComponent<Rigidbody2D>();
        rb.AddForce(transform.up * throwForce, ForceMode2D.Impulse);
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Blade")
        {
            Vector3 direction = (other.transform.position - transform.position).normalized;

            Quaternion rotation = Quaternion.LookRotation(direction);

            Instantiate(slicedFruitPrefab, transform.position, rotation);
            Destroy(gameObject);
        }
    }

}
