using UnityEngine;

public class DamageHandler : MonoBehaviour
{
    [SerializeField]
    [Range(50, 2500)]
    private int _HitPoints = 120;

    public bool IsDead { get; protected set; }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public virtual void HandleDamage(int damage)
    {
        if (_HitPoints > 0 && _HitPoints - damage > 0)
        {
            _HitPoints -= damage;
        }
        else
        {
            Die();
        }
    }

    protected virtual void Die()
    {
        _HitPoints = 0;
        IsDead = true;
        Destroy(gameObject);
    }

    protected void OnDestroy()
    {
        // TODO: Play VFX, Animation or anything
    }
}
