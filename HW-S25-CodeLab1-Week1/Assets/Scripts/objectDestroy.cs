using UnityEngine;

public class objectDestroy : MonoBehaviour
{
    public float gameObject;
    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Object.Destroy(other.gameObject);
        }
    }
}
