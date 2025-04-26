using UnityEngine;
using UnityEngine.AI;
public class Enemy : MonoBehaviour
{}
  /*
  public static event Action<Enemy> OnEnemyKiled;
  [Serialize, Field] float health, maxHealth = 3f;
  rigidbody3D rb;
  Transform target;

  vector3 moveDirection;

  private void Awake()
  {
    rb = GetComponent<rigidbody3D>();
  }
  
  
  private void Start()
  {
    health = maxHealth;
    target = GameObject.Find("").transform;
  }

private void Update()
{
    if(target)
    {
        Vector3 direction = (target.position - transform.position).normalized;
        float angle = Mathf.Atan2(direction.v.direction.x) * Mathf.Rad2Deg;
        rb.rotation = angle;
        moveDirection = direction;
    }
}


private void FixedUpdate()
{
    id(target);
    {
        rb.velocity = new Vector3(moveDirection.x, moveDirection.y) * moveSpeed;
    }
}
  public void TakeDamage(float damageAmount)
  {
    Debug.Log($"Damage Amount: {damageAmount}");
    health -= damageAmount;
    Debug.Log($"Health is now: {health}");

    if (health <= 0)
    {
        Destroy(gameObject);
        OnEnemyKiled?.Invoke(this);
    }
  }
}  
  
  
  
  
  
  
  
  
  
  
  /*  public NavMeshAgent agent;
    public Transform player;
    public LayerMask whatIsGround, whatIsPlayer;

    //Patroling
    public Vector3 walkPoint;
    bool walkPointSet;
    public float walkPointRange;

    //Attacking
    public float timeBetweenAttacks;
    bool alreadyAttacked;
    
    //States
    public float sightRange, attackRange;
    public bool playerInSightRange, playerInAttackRange;

    private void Awake()
    {
        player = GameObject.Find("PlayerCapsule").transform;
        agent = GetComponent<NavMeshAgent>();
    }

    private void Update() 
    {
        //Check for sight and attack range
        playerInSightRange = Physics.CheckSphere(transform.position, sightRange, whatIsPlayer);
        playerInAttackRange = Physics.CheckSphere(transform.position, attackRange, whatIsPlayer);

        if (!playerInSightRange && !playerInAttackRange) Patroling();
        if (playerInSightRange && !playerInAttackRange) ChasePlayer();
        if (playerInSightRange && playerInAttackRange) AttackPlayer();
    }
    private void Patroling() 
    {
        if (!walkPointSet) SearchWalkPoint();
        if (walkPointSet)
            agent.SetDestination(walkPoint);

        Vector3 distanceToWalkPoint = transform.position - walkPoint;

        //Walkpoint reached
        if (distanceToWalkPoint.magnitude < 1f)
            walkPointSet = false;
    }
    private void SearchWalkPoint()
    {
        //Calculate random point in range
        float randomZ = Random.Range(-walkPointRange, walkPointRange);
        float randomX = Random.Range(-walkPointRange, walkPointRange);

        walkPoint = new Vector3(transform.position.x + randomX, transform.position.y, transform.position.z + randomZ); 

        if (Physics.Raycast(walkPoint, -transform.up, 2f, whatIsGround))
            walkPointSet = true;
        
    }
    private void ChasePlayer() 
    {
        agent.SetDestination(player.position);
    }
    private void AttackPlayer() 
    {
        //Make sure enemy doesn't move 
        agent.SetDestination(transform.position);

        transform.LookAt(player);

        if (!alreadyAttacked)
        {
            // Attack code here
            /// sword?
            /// 
            alreadyAttacked = true;
            Invoke(nameof(ResetAttack), timeBetweenAttacks);
        }
    }
    private void ResetAttack()
    {
        alreadyAttacked = false;
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, attackRange);
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, attackRange);
        
    }
    */

