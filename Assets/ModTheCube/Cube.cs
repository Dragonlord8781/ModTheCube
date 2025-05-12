using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public MeshRenderer Renderer;

    private float randomR;
    private float randomG;
    private float randomB;
    private float randomA;

    private float startDelay = 5.0f; // start delay
    private float switchInterval; // spawn delay

    void Start()
    {
        randomR = Random.value;
        randomG = Random.value;
        randomB = Random.value;
        randomA = Random.value;

        switchInterval = Random.Range(1, 10);

        transform.position = new Vector3(3, 4, 1);
        transform.localScale = Vector3.one * 1.3f;
        
        Material material = Renderer.material;
        
        material.color = new Color(randomR, randomG, randomB, randomA);

        InvokeRepeating("RandomColor", startDelay, switchInterval);
        InvokeRepeating("RandomValues", startDelay, switchInterval);
    }
    
    void RandomColor()
    {
        Material material = Renderer.material;

        material.color = new Color(randomR, randomG, randomB, randomA);
    }

    void RandomValues()
    {
        randomR = Random.value;
        randomG = Random.value;
        randomB = Random.value;
        randomA = Random.value;
    }
    void Update()
    {
        transform.Rotate(10.0f * Time.deltaTime, 0.0f, 0.0f);
    }
}
