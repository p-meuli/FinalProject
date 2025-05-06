using UnityEngine;
// Enemy AI
public class Enemy2 : MonoBehaviour
{
    [SerializeField]
    private GameObject AttackOrigin;
    public GameObject player;
    
    //VARIABLES: PlayerDistance, ChaseRange, AttackRange, IdlePosition
    [SerializeField]
    private float ChaseRange = 5.0f;
    [SerializeField]
    private float AttackRange = 1.0f, AttackCooldown = 1.0f, CooldownTimer;
    [SerializeField]
    private float Speed = 5.0f;
    
    private bool isInCooldown = false;
    
    private Vector3 HomeLocation;
    
    //Start is called before the first frame update
    void Start()
    {
        HomeLocation = transform.position;
        CooldownTimer = AttackCooldown;
    }
    
    //update is called once per frame 
    void Update()
    {
        //playerLocation = get player location
        //playerDistance = absolute value of playerDistance - enemy position(hint: we can use Unity's vector3 Distance function for this)
        //Object.FindFirstObjectByType
       // var playerLocation = FindObjectOfType<PlayerController>().transform.position;
        var playerLocation = player.transform.position;
        var playerDistance = Vector3.Distance(playerLocation, transform.position);
    
    //IF PlayerDistance is lees than ChaseRange:
    //Attack()
    if (playerDistance < ChaseRange) 
    {
        transform.LookAt(playerLocation);
        transform.position += transform.forward * Time.deltaTime * Speed;
    
        //IF PlayerDistance is less than AttackRange; 
        //Attack()
        if (playerDistance < AttackRange) 
        {
            Attack();
            
        }
    }
    else if (transform.position != HomeLocation)
    {
        //Else IF: enemyPosition is not equal to IdlePosition:
        //Look at IdlePosition
       //Move towards the IdlePosition+/
       transform.LookAt(HomeLocation);
       transform.position += transform.forward * Time.deltaTime * Speed;
       
       if (Vector3.Distance(HomeLocation, transform.position) < .1f)
       {
            transform.position = HomeLocation;
       }
        
        
    }
}
private void Attack(/* Int Damage*/){}
}