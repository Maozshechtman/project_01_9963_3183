﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Tester
    {
        #region Fileds
        /*1*/
        public string Name { get; set; }
        /*2*/
        public string FamilyName { get; set; }
        /*3*/
        public string Id { get; set; }
        /*4*/
        public DateTime BirthDate { get; set; }
        /*5*/
        public gender MyGender { get; set; }
        /*6*/
        public string PhoneNumber { get; set; }
        /*7*/
        public Address MyAddress { get; set; }
        /*8*/
        public int YearsOfExperience { get; set; }
        /*9*/
        public int MaxTestsPerWeek { get; set; }
        /*11*/
        public carType ExpiranceCar { get; set; }
        /*12*/

       public bool[,] WorkHours { get;set;}//check when tester works
        /*13*/
       public int MaxDistance { get; set; }
        
        public Tester(string id, string name, string familyName,DateTime birthD, gender g,string phoneNum,Address address, int yearsE,int maxTest,carType type, int max_distance,bool[,] mat)
        {
            Id = id;
            Name = name;
            FamilyName = familyName;
            BirthDate = birthD;
            MyGender = g;
            PhoneNumber = phoneNum;
            MyAddress = address;
            YearsOfExperience = yearsE;
            MaxTestsPerWeek = maxTest;
            ExpiranceCar = type;
            MaxDistance = max_distance;
            WorkHours = new bool[5, 6];
            for (int i=0;i<5;i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    WorkHours[i, j] = mat[i, j];
                }
            }
        }
        #endregion

        
        private string ShowTable(bool[,] mat)
        {
            //Print work hours table 
            string str="";
            int j = 0;
            for (int i = 0; i <5; i++)
            {
                switch (i)
                {
                    case 0:
                        str+= "Sunday: ";
                        break;
                    case 1:
                        str += "Monday: ";
                        break;
                    case 2:
                        str += "Tuesday: ";
                        break;
                    case 3:
                        str += "Wednesday: ";
                        break;
                    case 4:
                        str += "Thursday: ";
                        break;
                };
                for(j=0;j<6;j++)
                {
                    if (mat[i, j] == true)
                        str += (((j )%10)+ ((j )/ 10))+9 + ":00" +" ";
                }
                str += "\n";
            }
            return str;
        }
        private string showAdress(Address a)
        {
            return a.streetName + " " + a.houseNumber + " " + a.city;
        }
        public override string ToString()
        {
            return "ID:"+Id+"\n"+ "Name:" +Name+" "+FamilyName+ "\n"+"Address: "+showAdress(MyAddress)+"\n"+"Phone:"+PhoneNumber+"Birth date:"+BirthDate+"\n"+"Gender: "+this.MyGender+"\n"+ "Years of experience: "+ YearsOfExperience+"\n"+"Car tape: "+this.ExpiranceCar+"\n"
                +"Max tests per week:"+"\n"+"Max distance: "+this.MaxDistance+"\n"+this.MaxTestsPerWeek+"\n"+ShowTable(this.WorkHours);
        }
    }
}