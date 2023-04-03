using Unity.VisualScripting;
using UnityEngine;

public class MagicShot : MonoBehaviour
{
    [SerializeField]
    [Range(10, 100)]
    public int Speed = 10;

    [SerializeField]
    [Range(10, 1000)]
    public int Damage = 50;

    private GameObject _Target;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        HandleMove();
    }

    protected void HandleMove()
    {
        if (_Target != null && !_Target.IsDestroyed())
        {
            PointAt(_Target.transform);
            MoveToward(_Target.transform);
        }
    }

    protected virtual void PointAt(Transform target)
    {
        transform.LookAt(target);
    }

    protected virtual void MoveToward(Transform target)
    {
        var nextPose = (transform.position - target.position).normalized * (Speed * Time.deltaTime);
        transform.position = transform.position + nextPose;
    }

    protected void OnCollisionEnter(Collision collision)
    {
        if (collision.collider != null && collision.collider.TryGetComponent(out DamageHandler dh))
        {
            if (!dh.IsDestroyed())
                dh.HandleDamage(Damage);
        }
    }
}
