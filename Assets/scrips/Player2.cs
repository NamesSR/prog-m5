using UnityEngine;
using TMPro;
using System;
public class Player2 : MonoBehaviour
{

    public static event Action<int> addScore;
    public float speed = 5f;
    

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");


        float z = Input.GetAxisRaw("Vertical");

        Vector3 velocity = new Vector3(x, 0, z) * speed;

        transform.position += velocity * Time.deltaTime;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "pickUp")
        {
            addScore?.Invoke(50);
            Destroy(other.gameObject);
        }
    }
}
