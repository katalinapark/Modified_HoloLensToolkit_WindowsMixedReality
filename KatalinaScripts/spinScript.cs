
using UnityEngine;
using System.Collections;

public class spinScript : MonoBehaviour
{
    public float seconds = 22f; 
    public float speed = 13f; 

    void Update()
    {
        StartCoroutine(Example());
    }

    IEnumerator Example()
    {
        yield return new WaitForSeconds(seconds);
        transform.Rotate(Vector3.up, speed * Time.deltaTime);

    }
}