using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Move : MonoBehaviour, IBeginDragHandler, IDragHandler
{
    public float speed;
    public GameObject sphere;

    Rigidbody rb;

    void IBeginDragHandler.OnBeginDrag(PointerEventData eventData)
    {
        Vector3 movement = new Vector3(eventData.delta.x * speed, rb.velocity.y, eventData.delta.y * speed);
        rb.AddForce(movement);
    }

    void IDragHandler.OnDrag(PointerEventData eventData)
    {
        Vector3 movement = new Vector3(eventData.delta.x * speed, rb.velocity.y, eventData.delta.y * speed);
        rb.AddForce(movement);
    }

    // Start is called before the first frame update
    void Start()
    {
        rb = sphere.GetComponent<Rigidbody>();
    }
}
