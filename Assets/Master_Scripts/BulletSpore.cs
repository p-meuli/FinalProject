using UnityEngine;

public class BulletSpore : MonoBehaviour
{
   private void OnCollisionEnter(Collision collision)
  {
  Destroy(gameObject);
  }
}

// Bullet, spore
// Empty game object - barrel
// sphere 0.05, 0.05, 0.05, add componet ridgid body, put bullet script on bullet. add bullet tag on bullet and enemy.
