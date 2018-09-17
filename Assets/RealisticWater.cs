using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RealisticWater : MonoBehaviour {
    private Renderer waterRenderer;

    // Use this for initialization
    void Start () {
        waterRenderer = GetComponent<Renderer>();
    }
	
	// Update is called once per frame
	void Update () {
        waterRenderer.material.SetFloat("_RandomY", Random.Range(0.9f, 1.1f));
	}
}
