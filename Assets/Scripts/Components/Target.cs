using System;
using UnityEngine;
using UnityEngine.UI;

public class Target : MonoBehaviour
{
    [SerializeField]
    private GameObject _nonDestroyedDummy = null;
    [SerializeField]
    private GameObject _destroyedDummy = null;
    [SerializeField]
    private int Score = 1;
    private float Reset = 0.1f;

    private bool _isDestroyed = false;

    private void Awake()
    {
        _nonDestroyedDummy.SetActive(true);
        _destroyedDummy.SetActive(false);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (_isDestroyed)
        {
            return;
        }
        
        Debug.Log("OnCollisionEnter", this);
        _nonDestroyedDummy.SetActive(false);
        _destroyedDummy.SetActive(true);

        var rigidbodies = _destroyedDummy.GetComponentsInChildren<Rigidbody>();
        foreach (var body in rigidbodies)
        {
            body.AddExplosionForce(400.0f, collision.contacts[0].point, 5.0f);
        }

        ScoreManager.Instance.ModifyScore(Score);

        FrostEffect.Instance.ResetFrost(Reset);

        _isDestroyed = true;

        
    }

}
