using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class ResetLevel : MonoBehaviour
{


void OnTriggerExit2D(Collider2D other) {
SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
}


}
