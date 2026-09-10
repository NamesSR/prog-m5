using UnityEngine;

public class tower : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        float x = Random.Range(0f, 1f);
        float y = Random.Range(0f, 1f);
        float z = Random.Range(0f, 1f);
        float xpos = Random.Range(0f, 9f);
        float zpos = Random.Range(0f, 9f);
        
        transform.localScale = new Vector3(x, y, z);
        transform.position = new Vector3(xpos, y , zpos);
    }

    // Update is called once per frame
    
}
