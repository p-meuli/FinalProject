using UnityEngine;

public class boom : MonoBehaviour
{
    public GameObject explosionEffect;
    //int damage = 100;

    public float radius = 10f;
    public float explosionForce = 10f;
    
    //void OnCollisionEnter(Collision collision)
    private void OnTriggerEnter(Collider other)
    {
       
       if(other.transform.tag == "Player" || other.transform.tag == "Spore") 
       {
        Explode();
       }
        
    }

    //Method to make it explode;

    private void Explode()
    {
        //check nearby colliders;
        Collider[] colliders = Physics.OverlapSphere(transform.position, radius);

        foreach(Collider col in colliders)
        {
            Rigidbody rig = col.GetComponent<Rigidbody>();

            if (rig != null)
            {
                rig.AddExplosionForce(explosionForce, transform.position, radius, 2F, ForceMode.Impulse);
                //ApplyDamage(rig.gameObject.GetComponent<Health>()); if you have a script for player health.
            } 
            if (col.transform.tag == "Player" || col.transform.tag == "Spore")
            {
             Instantiate(explosionEffect, transform.position, transform.rotation);
            Destroy(gameObject);  
             

            }
        }
        
    }
}
