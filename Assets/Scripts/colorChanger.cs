using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colorChanger : MonoBehaviour
{
    [SerializeField] private GameObject cube;
    private Renderer cubeRenderer;
    
    [SerializeField] private GameObject sphere;
    private Renderer sphereRenderer;
    
    private float randomR, randomG, randomB;
    private Color newColor; 
    
    
    // Start is called before the first frame update
    void Start()
    {
        sphereRenderer = sphere.GetComponent<Renderer>();
        cubeRenderer = cube.GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            CastRay();
        }
    }

    private void CastRay()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;  
        if (Physics.Raycast(ray, out hit))  
        {
            if (hit.transform.name == "Cube")
            {
                Debug.Log(hit.collider.gameObject.name);
                changeColor();
            }
            
        }
    }

    private void changeColor()
    {
        randomR = Random.Range(0f, 1f);
        randomG = Random.Range(0f, 1f);
        randomB = Random.Range(0f, 1f);

        newColor = new Color(randomR, randomG, randomB, 1f);
        
        sphereRenderer.material.SetColor("_Color", newColor);
        cubeRenderer.material.SetColor("_Color", newColor);
    }
}

