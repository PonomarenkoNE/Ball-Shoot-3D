using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoseWin : MonoBehaviour
{
    public GameObject door;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Win")
        {
            SceneManager.LoadScene("Win");
        }
        else if (other.gameObject.name == "Lose")
        {
            SceneManager.LoadScene("Lose");
        }
        else if (other.gameObject.name == "OpenDoor")
        {
            door.gameObject.GetComponent<Animation>().Play();
            Destroy(other);
        }
    }
}
