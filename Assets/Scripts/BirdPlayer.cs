using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdPlayer : MonoBehaviour
{
    [SerializeField] float maxDragDistance = 5f;
    public Transform SlingshotLeft, SlingshotRight;
    private bool isDragging = false;
    private Rigidbody2D birdRigidbody;
    private SpringJoint2D springJoint;
    private Vector2 SlingshotMiddleVector;

    void Start()
    {
        birdRigidbody = GetComponent<Rigidbody2D>();
        springJoint = GetComponent<SpringJoint2D>();
        birdRigidbody.isKinematic = true;
        
        SlingshotMiddleVector = new Vector2((SlingshotLeft.position.x + SlingshotRight.position.x) / 2, (SlingshotLeft.position.y + SlingshotRight.position.y) / 2);
    }

    void Update()
    {
        if (isDragging)
        {
            Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            if (Vector2.Distance(mousePosition, SlingshotMiddleVector) > maxDragDistance)
                birdRigidbody.position = SlingshotMiddleVector + (mousePosition - SlingshotMiddleVector).normalized * maxDragDistance;
            else
                birdRigidbody.position = mousePosition;
        }
    }

    private void OnMouseDown() {
        isDragging = true;
    }

    private void OnMouseUp() {
        isDragging = false;
        birdRigidbody.isKinematic = false;
        springJoint.enabled = false;

        // Calculate the direction from the bird to the slingshot and apply force in that direction.
        Vector2 forceDirection = SlingshotMiddleVector - birdRigidbody.position;
        birdRigidbody.AddForce(forceDirection * 200f);
    }
}

