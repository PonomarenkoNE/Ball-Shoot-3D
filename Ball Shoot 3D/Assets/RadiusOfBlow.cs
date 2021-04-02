using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RadiusOfBlow : MonoBehaviour
{
    public Material blue;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name.Contains("Blow"))
        {
            Destroy(other.gameObject);
            this.gameObject.GetComponent<MeshRenderer>().material = blue;
            this.gameObject.GetComponent<Rigidbody>().useGravity = true;
            this.gameObject.GetComponent<Rigidbody>().isKinematic = false;
        }
    }
}
