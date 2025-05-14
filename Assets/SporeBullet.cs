using UnityEngine;

public class SporeBullet : MonoBehaviour
{

    private void OnCollisionEnter(Collision collision)
    {

        if(collision.gameObject.TryGetComponent<Enemy2>(out Enemy2 enemyComponent)) 
        {
            enemyComponent.TakeDamage(5);
        }

    }
}
