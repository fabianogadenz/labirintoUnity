using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class spinning : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 1000f;

    public GameObject player;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up, speed * Time.deltaTime);
    }

   public void OnTriggerEnter(Collider other) {
        if(other.gameObject.tag == "Player") {
            //Destroy(player);
            SceneManager.LoadScene("GameOver");
        }
    }
}
