using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hit : MonoBehaviour
{
    public Material blue;
    public GameObject blow;

    private void OnTriggerEnter(Collider other)
    {
        GameObject tmp_blow = Instantiate(blow, transform.position, Quaternion.identity);
        tmp_blow.gameObject.transform.localScale = new Vector3(2 + this.gameObject.transform.localScale.x*2, 2 + this.gameObject.transform.localScale.x*2, 2 + this.gameObject.transform.localScale.x*2);
        other.gameObject.GetComponent<MeshRenderer>().material = blue; 
        other.gameObject.GetComponent<Rigidbody>().useGravity = true;
        other.gameObject.GetComponent<Rigidbody>().isKinematic = false;
    }

    private void OnTriggerExit(Collider other)
    {
        Destroy(this.gameObject);
    }
}
