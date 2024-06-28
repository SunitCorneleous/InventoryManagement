using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InventoryManagementMVC.Models
{
    public class Equipment
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Count { get; set; }
        public DateTime EntryDate { get; set; }

        public static List<Equipment> GetEquipmentList()
        {
            List<Equipment> list = new List<Equipment>();

            Equipment equipment = new Equipment();
            equipment.Id = 0;
            equipment.Name = "Laptop";
            equipment.Count = 10;
            equipment.EntryDate = DateTime.Now.Date;
            list.Add(equipment);

            equipment = new Equipment();
            equipment.Id =1;
            equipment.Name = "Desktop";
            equipment.Count = 30;
            equipment.EntryDate = DateTime.Now.Date;
            list.Add(equipment);

            equipment = new Equipment();
            equipment.Id =2;
            equipment.Name = "Printers";
            equipment.Count = 15;
            equipment.EntryDate = DateTime.Now.Date;
            list.Add(equipment);

            equipment = new Equipment();
            equipment.Id = 3;
            equipment.Name = "Projectors";
            equipment.Count = 7;
            equipment.EntryDate = DateTime.Now.Date;
            list.Add(equipment);

            return list;
        }
    }
}