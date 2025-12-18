using UnityEngine;

public class Collectible : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public float RotationSpeed;
    public GameObject OnCollectEffect;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate (0, RotationSpeed, 0);
    }
    
    private void OnTriggerEnter ( Collider other )
    {
        if ( other.CompareTag ( "Player" ) )
        {
            Instantiate ( OnCollectEffect, transform.position, transform.rotation );
            Destroy ( gameObject );
        } 
    }
}
