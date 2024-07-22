using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    [SerializeField] private GameObject ScoreObject;
    [SerializeField] private int ScoreAmount = 10;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < ScoreAmount; i++)
		{
            float x = Random.Range(-10.0f, 10.0f);
            float z = Random.Range(-10.0f,  );
            Instantiate(ScoreObject, new Vector3(x, 0.5f, z), Quaternion.identity);
		}
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
