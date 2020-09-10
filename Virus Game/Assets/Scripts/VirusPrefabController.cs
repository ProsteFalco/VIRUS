using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VirusPrefabController : MonoBehaviour
{
    public Rigidbody2D rb;
    public Vector2 startPosition;
    

    private void Awake()
    {
        rb = this.GetComponent<Rigidbody2D>();
        Vector3 force = new Vector3(Random.Range(-3,3),Random.Range(1,5),0);
        rb.AddForce(force, ForceMode2D.Impulse);
        startPosition = this.transform.position;

    }

    public void Update()
    {
        if (Mathf.Abs(startPosition.y - this.gameObject.transform.position.y) > 7)
        {
            Destroy(this.gameObject);
        }

            
    }

}
