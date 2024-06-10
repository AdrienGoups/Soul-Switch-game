using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMove : MonoBehaviour
{
    [SerializeField]
    private float _speed = 200.0f;
    [SerializeField]
    private float _turnSpeed = 100.0f;
    
    // Valeurs de contrôle de déplacement du joueur. Entre -1 et 1: Sans mouvement, les valeurs sont à 0
    private float _mouvementHorizontal;
    private float _mouvementVerticale;

    private Vector2 _touchesClavier;
    private Vector3 _input;

    private Rigidbody _rb;

    private Vector3 _skewedInput;
    
    private void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        BougeJoueur();
        Look();
    }

    public void OnMove(InputValue value)
    {
        _touchesClavier = value.Get<Vector2>();
        Debug.Log(_touchesClavier);
        _input = new Vector3(_touchesClavier.x, 0, _touchesClavier.y);
    }

    void Look(){
        if(_input != Vector3.zero){

            var matrix = Matrix4x4.Rotate(Quaternion.Euler(0,45,0));

            _skewedInput = matrix.MultiplyPoint3x4(_input);

            var relative = (transform.position + _skewedInput) - transform.position;
            var rot = Quaternion.LookRotation(relative, Vector3.up);

            transform.rotation = Quaternion.RotateTowards(transform.rotation, rot, _turnSpeed * Time.fixedDeltaTime);
        }
    }

    private void BougeJoueur()
    {
        // transform.Translate(_mouvementHorizontal * _speed * Time.fixedDeltaTime, 0, _mouvementVerticale * _speed * Time.fixedDeltaTime);
        _rb.velocity = new Vector3(_skewedInput.x * _speed * Time.fixedDeltaTime, 0, _skewedInput.z * _speed * Time.fixedDeltaTime );

    }
}
