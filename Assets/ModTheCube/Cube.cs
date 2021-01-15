using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public MeshRenderer Renderer;
    public float timeGap = 0.3f;

    private float elapsedTime = 0.0f;

    private Material material;

    void Start()
    {
        transform.position = new Vector3(Random.Range(1.0f, 4.0f), Random.Range(1.0f, 4.0f), Random.Range(1.0f, 4.0f));
        transform.localScale = Vector3.one * Random.Range(0.5f, 2.0f);
        
        material = Renderer.material;
        
        
        material.color = RandomColor();
    }
    
    void Update()
    {
        transform.Rotate(Random.Range(10.0f, 25.0f) * Time.deltaTime, 0.0f, 0.0f);
        elapsedTime += Time.deltaTime;
        if(elapsedTime >= timeGap)
        {
            material.color = Color.Lerp(material.color, RandomColor(), timeGap - 0.1f);
            elapsedTime = 0.0f;
        }
    }

    private Color RandomColor()
    {
        //Color                       R                          G                          B                          A
        return new Color(Random.Range(0.01f, 1.0f), Random.Range(0.01f, 1.0f), Random.Range(0.01f, 1.0f), Random.Range(0.4f, 1.0f));
    }
}
