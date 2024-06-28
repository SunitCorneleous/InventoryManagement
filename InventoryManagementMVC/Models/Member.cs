using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InventoryManagementMVC.Models
{
    public class Member
    {
        public int MemberId { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        public string Designation { get; set; }

        public static List<Member> GetMemberList()
        {
            List<Member> list = new List<Member>();

            Member member = new Member();
            member.MemberId = 1;
            member.Name = "Alice Johnson";
            member.Department = "Human Resources";
            member.Designation = "HR Manager";
            list.Add(member);

            member = new Member();
            member.MemberId = 2;
            member.Name = "Bob Smith";
            member.Department = "IT";
            member.Designation = "Software Engineer";
            list.Add(member);

            member = new Member();
            member.MemberId = 3;
            member.Name = "Carol White";
            member.Department = "Finance";
            member.Designation = "Financial Analyst";
            list.Add(member);

            member = new Member();
            member.MemberId = 4;
            member.Name = "David Brown";
            member.Department = "Marketing";
            member.Designation = "Marketing Director";
            list.Add(member);

            member = new Member();
            member.MemberId = 5;
            member.Name = "Emily Davis";
            member.Department = "Sales";
            member.Designation = "Sales Executive";
            list.Add(member);

            member = new Member();
            member.MemberId = 6;
            member.Name = "Frank Wilson";
            member.Department = "IT";
            member.Designation = "Network Engineer";
            list.Add(member);

            member = new Member();
            member.MemberId = 7;
            member.Name = "Grace Miller";
            member.Department = "Research";
            member.Designation = "Research Scientist";
            list.Add(member);

            member = new Member();
            member.MemberId = 8;
            member.Name = "Henry Moore";
            member.Department = "Administration";
            member.Designation = "Admin Assistant";
            list.Add(member);

            member = new Member();
            member.MemberId = 9;
            member.Name = "Irene Taylor";
            member.Department = "Customer Support";
            member.Designation = "Support Specialist";
            list.Add(member);

            member = new Member();
            member.MemberId = 10;
            member.Name = "Jack Anderson";
            member.Department = "IT";
            member.Designation = "DevOps Engineer";
            list.Add(member);

            return list;
        }

    }
}