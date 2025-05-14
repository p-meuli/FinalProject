using System.Linq;
using UnityEngine;
using UnityEngine.InputSystem;

public class ShootSpore : MonoBehaviour
{
    public GameObject BulletPrefab;
    public Transform FirePoint;
    void Update()
    {
       
        if(Input.GetKeyDown(KeyCode.J)) 
        {
            GameObject bullet = Instantiate(BulletPrefab, FirePoint.position, Quaternion.identity);
            bullet.GetComponent<Rigidbody>().AddForce(transform.forward * 1000);
                
        }
       
    }
}