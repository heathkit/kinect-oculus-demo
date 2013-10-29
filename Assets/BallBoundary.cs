using UnityEngine;
using System.Collections;

public class BallBoundary : MonoBehaviour {
	
	public GameObject ballSpawnLocation;
	public GameObject ballPrefab;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnTriggerEnter( Collider other)
	{
		if( other.tag == "ball")
		{
			Destroy(other.gameObject); // destroy this ball
			Instantiate( ballPrefab, ballSpawnLocation.transform.position, ballSpawnLocation.transform.rotation);
		}
	}
}
