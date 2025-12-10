using UnityEngine;

public class Shop : MonoBehaviour
{
    //Zona de variables globales
    
    [SerializeField]
    private int _broccoliStock;
    [SerializeField]
    private int _potatoStock;

    //Cantidades que el usuario puede agregar o quitar
    [SerializeField]
    private int _addBroccoli;
    [SerializeField]
    private int _addPotato;
    [SerializeField]
    private int _removeBroccoli;
    [SerializeField]
    private int _removePotato;


    void Start()
    {
        Debug.Log("Cantidad Inicial de brócoli: " + _broccoliStock + " y de patata: " + _potatoStock);

        AddBroccoli(_addBroccoli);
        AddPotato(_addPotato);

        RemoveBroccoli(_removeBroccoli);
        RemovePotato(_removePotato);

        Debug.Log("Cantidad Final de brócoli: " + _broccoliStock + " y de patata: " + _potatoStock);
    }

    private void AddBroccoli(int amount)
    {
        _broccoliStock = _broccoliStock + amount;
        Debug.Log("Son añadidos " + amount + " brócolis y ahora hay " + _broccoliStock);
    }

    private void AddPotato(int amount)
    {
        _potatoStock = _potatoStock + amount;
        Debug.Log("Son añadidas " + amount + " patatas y ahora hay " + _potatoStock);
    }

    private void RemoveBroccoli(int amount)
    {
        _broccoliStock = _broccoliStock - amount;
        if (_broccoliStock < 0) _broccoliStock = 0;
        Debug.Log("Son retirados " + amount + " brócolis y ahora hay " + _broccoliStock);
    }

    private void RemovePotato(int amount)
    {
        _potatoStock = _potatoStock - amount;
        if (_potatoStock < 0) _potatoStock = 0;
        Debug.Log("Son retiradas " + amount + " patatas y ahora hay " + _potatoStock);
    }




}
