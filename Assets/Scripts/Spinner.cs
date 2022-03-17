using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner : MonoBehaviour
{
    [SerializeField] float XRotation = 0;
    [SerializeField] float YRotation = 0.5f;
    [SerializeField] float ZRotation = 0;

    void Start()
    {
        
    }

    void Update()
    {
        transform.Rotate(XRotation, YRotation, ZRotation);
    }
}
