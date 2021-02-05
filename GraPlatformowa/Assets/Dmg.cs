using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dmg : MonoBehaviour
{

	public float hp = 3f;


void OnTriggerExit2D(Collider2D other) {
hp -= 1;
}


    // Start is called before the first frame update
    void Start()
    {
	hp = 3f;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
