using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloatingObjectMover : MonoBehaviour
{
    [SerializeField] private float moveSpeed = -14.4f;

    private void Update() {
        // Move left.
        transform.Translate(moveSpeed * Time.deltaTime, 0f, 0f);
    }
}
