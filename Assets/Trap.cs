using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Trap : MonoBehaviour
{

    public GameObject player;
    // Start is called before the first frame update
   

    public void OnTriggerEnter(Collider other) {
        if(other.gameObject.tag == "Player") {
            //Destroy(player);
            SceneManager.LoadScene("GameOver");
        }
    }
}
