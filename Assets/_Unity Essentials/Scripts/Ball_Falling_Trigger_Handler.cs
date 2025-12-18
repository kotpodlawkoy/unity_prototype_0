using UnityEngine;

public class Ball_Falling_Trigger_Handler : MonoBehaviour
{
    public GameObject Ball;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Rigidbody rb = Ball.GetComponent <Rigidbody>();
        if ( rb != null )
        {
            rb.useGravity = false;
        }
        else
        {
            Debug.LogError ( "This object does not have RigidBody within" );
        }
        
    }

   private void OnTriggerEnter ( Collider other ) 
   {
      if ( other.CompareTag ( "Player" ) )
      {
          Debug.Log ( "Trigger activated" );
          Rigidbody rb = Ball.GetComponent <Rigidbody>();
          rb.useGravity = true;
          Destroy ( gameObject );
      }
   }
}
