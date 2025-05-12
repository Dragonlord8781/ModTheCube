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

    private float randomX;
    private float randomY;
    private float randomZ;

    private float startDelay = 5.0f; // start delay
    private float switchInterval; // spawn delay

    private Vector3 newPos;

    void Start()
    {
        randomR = Random.value;
        randomG = Random.value;
        randomB = Random.value;
        randomA = Random.value;

        randomX = Random.Range(2, 7);
        randomY = Random.Range(2, 9);
        randomZ = Random.Range(-4, 7);

        switchInterval = Random.Range(1, 10);

        transform.position = new Vector3(randomX, randomY, randomZ);
        transform.localScale = Vector3.one * 1.3f;
        
        Material material = Renderer.material;
        
        material.color = new Color(randomR, randomG, randomB, randomA);

        InvokeRepeating("RandomForms", startDelay, switchInterval);
        InvokeRepeating("RandomValues", startDelay, switchInterval);
    }
    
    void RandomForms()
    {
        Material material = Renderer.material;

        material.color = new Color(randomR, randomG, randomB, randomA);
        transform.position = new Vector3(randomX, randomY, randomZ);
    }

    void RandomValues()
    {
        randomR = Random.value;
        randomG = Random.value;
        randomB = Random.value;
        randomA = Random.value;

        randomX = Random.Range(2, 7);
        randomY = Random.Range(2, 9);
        randomZ = Random.Range(-4, 7);
    }

    void Update()
    {
        transform.Rotate(10.0f * Time.deltaTime, 0.0f, 0.0f);
    }
}
