﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Task_6
{
    class Student
        {
        private string name;

        public string Name 
        {
            get { return name; }
            set { name = value; }
        }
        private string id;

        public string Id
        {
            get { return id; }
            set { id = value; }
        }
        private string department;

        public string Department
        {
            get { return department; }
            set { deoartment = value; }
        }
        private float cgpa;

	public float Cgpa
	{
		get { return cgpa;}
		set { cgpa = value;}
	}
	
        public Student() { }
         
        public Student(string name, string id,string department, float cgpa)
        {
            this.name = name;
            this.id = id;
            this.department = department;
            this.cgpa=cgpa;
        }
         
        public void ShowInfo()
        {
           Console.WriteLine("Name: "+ Name)
           Console.WriteLine("ID: "+ id)
           Console.WriteLine("Department: "+ department)
           Console.WriteLine("Cgpa: "+ cgpa)

           
        }
   
   
  
}
