//This is the change

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

    [SerializeField] List<Transform> positions;
    int pos = 0;
    float speed = 2f;
    // Use this for initialization
    void Start () {
        
        transform.position = positions[pos].transform.position;

	}
	
	// Update is called once per frame
	void Update () {

        if (pos <= positions.Count)
        {
            transform.position = Vector2.MoveTowards(transform.position, positions[pos].transform.position, speed * Time.deltaTime);
            if (transform.position == positions[pos].transform.position)
            {
                pos++;
            }
        }
        else {
            Destroy(gameObject);
        }
		
	}
}
