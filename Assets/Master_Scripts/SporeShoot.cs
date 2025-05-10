using Unity.VisualScripting;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem.Processors;

public class SporeShoot : MonoBehaviour
{
 [SerializeField] GameObject referenceProjectile;
    [SerializeField] Transform barrel; //sporeShooter?
    
    Vector3 destination;
    
    void Update() 
    {
        if(Input.GetKeyDown(KeyCode.J)) //want it to be j keybutton, Input.GetKeyDown(KeyCode.J) Input.GetMouseButton(0)
        OnFire();
    }
    
    void CreateProjectile()
    {
       GameObject projectile = Instantiate(referenceProjectile, barrel.position, Quaternion.identity);
       Destroy(projectile, 10);
       projectile.GetComponent<Rigidbody>().AddForce((destination - projectile.transform.position).normalized * 50.0f, ForceMode.Impulse);
    }
    
    
    void OnFire()
    {
        Ray ray = Camera.main.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0));
        RaycastHit hit;
        
        if (Physics.Raycast(ray, out hit, Mathf.Infinity))
            destination = hit.point;
        else
            destination = ray.GetPoint(1000);
            
        CreateProjectile();
    } 
}
