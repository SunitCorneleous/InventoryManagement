using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InventoryManagementMVC.Models
{
    public class AssignedEquipment
    {
        public string EquipmentName { get; set; }
        public string MemberName { get; set; }
        public string MemberDepartment {  get; set; }
        public string MemberDesignation { get; set; }

        public static List<AssignedEquipment> GetEquipmentList()
        {
            List<AssignedEquipment> lst = new List<AssignedEquipment>();

            AssignedEquipment assignedEquipment = new AssignedEquipment();
            assignedEquipment.EquipmentName = "Laptop";
            assignedEquipment.MemberName = "Alice Johnson";
            assignedEquipment.MemberDepartment = "Human Resources";
            assignedEquipment.MemberDesignation = "HR Manager";
            lst.Add(assignedEquipment);

            assignedEquipment = new AssignedEquipment();
            assignedEquipment.EquipmentName = "Desktop";
            assignedEquipment.MemberName = "Bob Smith";
            assignedEquipment.MemberDepartment = "IT";
            assignedEquipment.MemberDesignation = "Software Engineer";
            lst.Add(assignedEquipment);

            assignedEquipment = new AssignedEquipment();
            assignedEquipment.EquipmentName = "Printer";
            assignedEquipment.MemberName = "Bob Smith";
            assignedEquipment.MemberDepartment = "IT";
            assignedEquipment.MemberDesignation = "Software Engineer";
            lst.Add(assignedEquipment);

            assignedEquipment = new AssignedEquipment();
            assignedEquipment.EquipmentName = "Printer";
            assignedEquipment.MemberName = "Alice Johnson";
            assignedEquipment.MemberDepartment = "Human Resources";
            assignedEquipment.MemberDesignation = "HR Manager";
            lst.Add(assignedEquipment);

            assignedEquipment = new AssignedEquipment();
            assignedEquipment.EquipmentName = "Laptop";
            assignedEquipment.MemberName = "Emily Davis";
            assignedEquipment.MemberDepartment = "Sales";
            assignedEquipment.MemberDesignation = "Sales Executive";
            lst.Add(assignedEquipment);

            return lst;
        }
    }
}