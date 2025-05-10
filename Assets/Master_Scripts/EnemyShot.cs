using UnityEngine;

public class EnemyShot : MonoBehaviour
{
//Enemy shot
/*
    int health = 100;
    public void TakeDamage()
    {
    health -=50;
    if(health <= 0)
        Dead();
    }
*/
 void Dead()
 {
    Destroy(gameObject);
 }
 private void OnCollisionEnter(Collision collision)
 {
    if(collision.gameObject.CompareTag("Bullet"))
    //    TakeDamage();
    Dead();
 }
}