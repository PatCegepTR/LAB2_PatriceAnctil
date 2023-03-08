using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //Attributs (priv� avec _ pour diff�rencier)
    [SerializeField] private float _vitesse = 500;
    private bool _estActif = true;
    private Rigidbody _rb;

    // M�thodes priv�es
    private void Start()
    {
        // Position de d�part du joueur
        transform.position = new Vector3(-46f, 0.01f, -46f);
        _rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        if (_estActif)
        {
            MouvementsJoueur();
        }
    }

    private void MouvementsJoueur()
    {
        float positionX = Input.GetAxis("Horizontal");
        float positionZ = Input.GetAxis("Vertical");
        Vector3 direction = new Vector3(positionX, 0f, positionZ);
        //transform.Translate(direction * Time.deltaTime * _vitesse);
        _rb.velocity = direction * Time.fixedDeltaTime * _vitesse;
        //_rb.AddForce(direction* Time.fixedDeltaTime * _vitesse);
    }


    // M�thode publique
    public void FinPartie()
    {
        //this.gameObject.SetActive(false);
        _estActif= false;
    }

}
