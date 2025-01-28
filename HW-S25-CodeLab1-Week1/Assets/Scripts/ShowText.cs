using UnityEngine;

public class ShowText : MonoBehaviour
{
   void OnTriggerEnter(Collider other)
   {
      if (other.gameObject.CompareTag("Player"))
      {
         Destroy(this.gameObject);
      }
   }
}
