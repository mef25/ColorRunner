using UnityEngine;

public class duvarrandom : randomYazi
{
    public GameObject gameObject;
    
    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
    }
}
