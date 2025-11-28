using UnityEngine;

public class Chest : interaction
{
    public Item[] itemsInside;
    private bool isOpen = false;

    public override void Interact()
    {
        if (!isOpen)
        {
            isOpen = true;
            Debug.Log("Cofre abierto!");
            ShowItems();
        }
        else
        {
            Debug.Log("El cofre ya está abierto.");
        }
    }

    void ShowItems()
    {
        foreach (var item in itemsInside)
        {
            Debug.Log("Item obtenido: " + item.itemName);
        }
    }
}
