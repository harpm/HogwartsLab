using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wizard : MonoBehaviour
{
    [SerializeField]
    private Animator _BodyAnim;

    [SerializeField]
    private Transform _StickHead;

    [SerializeField]
    [Range(5, 70)]
    private int _ShotMaxDistance = 10;

    [SerializeField]
    public MagicShot MagicShotPrefab;

    public Vector2 DestinationTeleportPose;
    public GameObject DestinationObjectForm;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ShotMagicDamage()
    {

    }

    public void TransportObject()
    {

    }

    public void TeleportObject()
    {

    }

    public void ConvertObject()
    {

    }
}
