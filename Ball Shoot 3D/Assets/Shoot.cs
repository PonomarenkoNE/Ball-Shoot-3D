using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Shoot : MonoBehaviour
{
    public GameObject bullet;
    public GameObject map;

    private float t;

    Rigidbody rb;

    // Update is called once per frame
    void Update()
    {
        if (this.gameObject.transform.localScale.x < 0.6f)
        {
            SceneManager.LoadScene("Lose");
        }
    }

    void OnMouseDown()
    {
        t = Time.time;
    }

    void OnMouseUpAsButton()
    {
        t = Time.time - t;
        this.gameObject.transform.localScale = new Vector3(this.gameObject.transform.localScale.z - t*1.1f, this.gameObject.transform.localScale.z - t*1.1f, this.gameObject.transform.localScale.z - t*1.1f);
        map.gameObject.transform.localScale = new Vector3(map.gameObject.transform.localScale.x - (t*0.1f), 1, 10);
        GameObject tmp_bullet = Instantiate(bullet, new Vector3(0, 0, 2) + transform.position, Quaternion.identity);
        tmp_bullet.transform.localScale = new Vector3(tmp_bullet.transform.localScale.z + t*1.1f, tmp_bullet.transform.localScale.z + t*1.1f, tmp_bullet.transform.localScale.z + t*1.1f);
        rb = tmp_bullet.GetComponent<Rigidbody>();
        Vector3 movement = new Vector3(rb.velocity.x, rb.velocity.y, transform.position.z+5000);
        rb.AddForce(movement);
    }
}
