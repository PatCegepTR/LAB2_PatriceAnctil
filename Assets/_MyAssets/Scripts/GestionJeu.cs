using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GestionJeu : MonoBehaviour
{
    //Attributs
    private int _pointage;

    public int GetPointage()
    {
        return _pointage;
    }

    private void Awake()
    {
        int nbGestionJeu = FindObjectsOfType<GestionJeu>().Length;
        if (nbGestionJeu>1)
        {
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }

    private void Start()
    {
        _pointage = 0;
        Instructions();

    }

    private static void Instructions()
    {
        Debug.Log("*** Prison ***");
        Debug.Log("�chape toi de la prison le plus rapidement possible");
        Debug.Log("Chaque obstacle qui sera touch� entraine une p�nalit�");
    }

    // M�thodes publiques
    public void AugmenterPointage()
    {
        _pointage++;
    }


}
