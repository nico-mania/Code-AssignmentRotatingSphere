using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SphereRotate : MonoBehaviour
{
    [SerializeField] private GameObject cube;
    [SerializeField] private Slider Speed;
    [SerializeField] private float rotateSpeed;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(cube.transform.position, Vector3.back, rotateSpeed * Time.deltaTime);
    }

    public void OnValueChanged(float value)
    {
        rotateSpeed = value;
    }
}
