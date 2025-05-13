using Unity.VisualScripting.FullSerializer;
using UnityEngine;

public class Projectiile : MonoBehaviour
{
    private Vector3 firingPoint;

    [SerializeField]
    private float projectileSpeed;
    [SerializeField]
    private float maxprojectileDistance;
    void Start()
    {
        firingPoint = transform.position;
    }

    void Update()
    {
        MoveProjectile();
    }
    void MoveProjectile()
    {
        if (Vector3.Distance(firingPoint, transform.position) > maxprojectileDistance)
        {
            //Destroy(this.gameObject);
        }
        else
        {
        transform.Translate(Vector3.forward * projectileSpeed * Time.deltaTime);
        }
    }
}
