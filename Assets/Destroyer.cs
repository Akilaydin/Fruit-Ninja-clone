using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour
{
    private void OnTriggerExit(Collider other) {
        Destroy(other.gameObject);
    }

    private void OnTriggerExit2D(Collider2D other) {
        Destroy(other.gameObject);
    }
}
