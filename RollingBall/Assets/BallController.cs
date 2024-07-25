using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallController : MonoBehaviour
{
    private Rigidbody rb;
    private int score = 0;
    [SerializeField] private Text scoreText;

	// Start is called before the first frame update
	void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.W))
		{
			rb.AddForce(new Vector3(0, 0, 1));
		}

        if(Input.GetKey(KeyCode.S))
        {
            rb.AddForce(new Vector3(0, 0, -1));
		}

        if(Input.GetKey(KeyCode.A))
		{
			rb.AddForce(new Vector3(-1, 0, 0));
        }

		if(Input.GetKey(KeyCode.D))
        {
            rb.AddForce(new Vector3(1, 0, 0));
		}
    }

    private void OnTriggerEnter(Collider other)
	//private void OnCollisionEnter(Collision collision)
	{
		if(other.gameObject.name == "Score(Clone)")
		{
			score++;
			Debug.Log("Score: " + score);
			Destroy(other.gameObject);
			scoreText.text = "Score: " + score;
		}
	}
}
