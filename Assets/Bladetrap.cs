using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Bladetrap : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject player;

   public void OnTriggerEnter(Collider other) {
        if(other.gameObject.tag == "Player") {
            SceneManager.LoadScene("GameOver");
        }
    }
}
