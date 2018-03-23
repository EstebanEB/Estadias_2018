using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName ="Inventory System/Database")]
public class database : ScriptableObject {

    public List<Item> items = new List<Item>(); //creando la lista de objetos

    public Item FindItemInDatabase(int id) // aqui se comienza con la busqueda de objetos
    {
        foreach (Item item in items) //Se recorre el arreglo
        {
            if (item.id == id)  //si el objeto se encuentra en la base de datos
            {
                return item;
            }
        }
        return null; // si no encuentra el item no regresa nada
    }
}

[System.Serializable]
public class Item
{
    public int id;
    public Sprite target;
    public string nombre;
    [TextArea(5,3)]
    public string descripcion;
}
