using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class apple : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.CompareTag("ground"))
        {
            HealthManager.instance.DecreaseHealth();
            Destroy(this.gameObject);

        }
    }
    private void OnTriggerEnter(Collider apple)
    {
        if (apple.CompareTag("sepet"))
        {
            Destroy(apple.gameObject);
        }
    }
}
