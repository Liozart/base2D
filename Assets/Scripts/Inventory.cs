using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour {

	List<Item> content;

	// Use this for initialization
	void Start () {
		content = new List<Item>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void AddItem(Item item) {
		content.Add(item);
	}

	public string InventoryToString() {
		string res = "";
		foreach (Item itm in content) {
			res += "\n" + itm.name; 
		}
		return res;
	}
}
