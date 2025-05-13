using UnityEditor.Rendering;
using UnityEngine;

public class SporeBullet : MonoBehaviour
{
 /*
    void Start()
    {
        // set spore with spore tag
        gameObject.tag = "Spore";
    }
    */
    private void OnCollisionEnter(Collision collision)
    {
        //Destroy(gameObject);   
        //Enemys to take damage

        if(collision.gameObject.TryGetComponent<Enemy2>(out Enemy2 enemyComponent)) 
        {
            enemyComponent.TakeDamage(5);
        }

       /*
        if(Collision.tag = "Enemy")
        {

        }
        if(collision.tag = "boomer") 
        */
    }
}
