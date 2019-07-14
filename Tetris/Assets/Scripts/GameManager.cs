using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public GameObject[] tetrominoes;
    
    
    
    
    // Use this for initialization
	void Start () {
        SpawnTetromino();
	}
	
	// Update is called once per frame
	void Update () {
		
	}


    public void SpawnTetromino()
    {
        Instantiate(tetrominoes[Random.Range(0, tetrominoes.Length)], transform.position, Quaternion.identity);


    }
}
