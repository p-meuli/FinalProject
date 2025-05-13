using System.Linq;
using JetBrains.Rider.Unity.Editor;
using UnityEngine;
using UnityEngine.InputSystem;

public class ShootSpore : MonoBehaviour
{
    public GameObject BulletPrefab;
    public Transform FirePoint;
    void Update()
    {
        /*
        if(Input.GetKeyDown(KeyCode.J)) 
        {
            GameObject bullet = Instantiate(BulletPrefab, FirePoint.position, Quaternion.identity);
            bullet.GetComponent<Rigidbody>().AddForce(transform.right * 1000);
        }
*/
        if(Input.GetKeyDown(KeyCode.J)) 
        {
            GameObject bullet = Instantiate(BulletPrefab, FirePoint.position, Quaternion.identity);
            bullet.GetComponent<Rigidbody>().AddForce(transform.forward * 1000);
                
        }
       
       /*
         if(Input.GetKeyDown(KeyCode.J)) 
         {
            GameObject bullet = Instantiate(BulletPrefab, FirePoint.position, Quaternion.identity);
             bullet.GetComponent<Rigidbody>().AddForce(transform.up * 1000);
         }
        */
        


    }
}












/*{

public GameObject BulletPrefab; 

void Update()
{
    if(Input.GetKeyDown(KeyCode.J)) //FirePosition
    {
        GameObject bullet = Instantiate(BulletPrefab, FirePoint.position, Quaternion.identity);
        bullet.GetComponent<Rigidbody>().AddForce(transform.right = 1000f);
    }
    

// Spore prefab
// FirePosition gameObject
}
}
*/