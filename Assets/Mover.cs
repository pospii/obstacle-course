using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        transform.Translate(1, 0.667f, 20);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0.001f, 0, 0);
    }
}
