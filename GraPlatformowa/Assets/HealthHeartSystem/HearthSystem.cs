using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HearthSystem : MonoBehaviour
{

public GameObject[] hearts;
public int life;
public float invulTime = 3f;

private bool invulnerable = false;


IEnumerator JustHurt()
    {
	invulnerable = true;
        yield return new WaitForSeconds(invulTime);
	invulnerable = false;
    }




void OnTriggerEnter2D (Collider2D collision){


if (collision.gameObject.layer == 9 && invulnerable == false){


if (life == 1){
Destroy(hearts[0].gameObject);
life -= 1;
SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
}


if (life == 2){
Destroy(hearts[1].gameObject);
life -= 1;
StartCoroutine(JustHurt());
}



if (life == 3){

Destroy(hearts[2].gameObject);
life -= 1;
StartCoroutine(JustHurt());
}




}


}

}
