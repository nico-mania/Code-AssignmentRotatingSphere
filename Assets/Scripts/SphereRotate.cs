using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereRotate : MonoBehaviour
{
    [SerializeField] private GameObject cube;
    [SerializeField] private float rotateSpeed = 100;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(cube.transform.position, Vector3.back, rotateSpeed * Time.deltaTime);
    }
}
