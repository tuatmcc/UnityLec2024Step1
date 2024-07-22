using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] private Transform PlayerObject;
    [SerializeField] private Vector3 offset;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = PlayerObject.position + offset;
    }
}
