using UnityEngine;

public class SporeShoot2 : MonoBehaviour
{
   public GameObject BulletPrefab;
    public Transform FirePoint;
    void Update()
    {
         if(Input.GetKeyDown(KeyCode.U)) 
         {
            GameObject bullet = Instantiate(BulletPrefab, FirePoint.position, Quaternion.identity);
             bullet.GetComponent<Rigidbody>().AddForce(transform.forward * -1000);
         }

         if(Input.GetKeyDown(KeyCode.U)) 
         {
            GameObject bullet = Instantiate(BulletPrefab, FirePoint.position, Quaternion.identity);
             bullet.GetComponent<Rigidbody>().AddForce(transform.up * 1000);
         }

         if(Input.GetKeyDown(KeyCode.U)) 
         {
            GameObject bullet = Instantiate(BulletPrefab, FirePoint.position, Quaternion.identity);
             bullet.GetComponent<Rigidbody>().AddForce(transform.right * 1000);
         }
    }
}
