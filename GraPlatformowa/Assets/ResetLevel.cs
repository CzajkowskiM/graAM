using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class ResetLevel : MonoBehaviour
{

private Scene scene;

void Start()
{
scene = SceneManager.GetActiveScene();
}

void OnTriggerEnter(Collider other)
{
if (other.gameObject.tag == "Player")
	{
	SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
	}

}

void OnTriggerExit(Collider other) {
SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
}


}
