using System;

public class Inventory
{
    public ItemDB DB;
    public List<Item> inventory = new List<Item>();
    public List<Item> slots = new List<Item>();
    public int slotCount = slots.Count;
    private bool showToolTip;
    private String toolTip;

	public Inventory()
	{
        for (int i = 0; inventory.Count; i++)
        {
            slots.add(new Item());
        }

	}


}
