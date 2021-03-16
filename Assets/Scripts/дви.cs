using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class дви : MonoBehaviour
{
    [SerializeField]
    private Vector3 __direction;

    [SerializeField]
    private float __speed;

    private void Update()
    {
        __direction.x = Input.GetAxis("Horizontal");
        __direction.z = Input.GetAxis("Vertical");

    }

    private void FixedUpdate()
    {
        var mor = __direction * (__speed * Time.deltaTime);
        transform.Translate(mor);
    }
}