using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deer01 : MonoBehaviour
{
    public Transform[] target01;
    public float spreed01;

    private int current01;

    void Update()
    {
        if (transform.position != target01[current01].position)
        {
            Vector3 pos = Vector3.MoveTowards(transform.position, target01[current01].position, spreed01 * Time.deltaTime);
            GetComponent<Rigidbody>().MovePosition(pos);
        }
        else if ((transform.position == target01[current01].position))
        {
            current01 = (current01 + 1) % target01.Length;
        }
    }
}
