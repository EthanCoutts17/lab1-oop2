using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1_oop2
{
    internal class Person
    {
        public int personId;
        public string firstName;
        public string lastName;
        public string favoriteColour;
        public int age;
        public bool isWorking;


        public string DisplayPersonInfo()
        {
             return " \n Person ID: " + personId + "\n First Name: " + firstName + " \n last Name: " + lastName + " \n Favorite Color: " + favoriteColour + " \n Age: " + age + " \n isworking: " + isWorking;

        }


        public void ChangeFavoriteColor()
        {
            favoriteColour = "white";
        }


        public void GetAgeInTenyears()
        {
            age += 10;
        }


        public string ToString()
        {
            return  personId + ":" + firstName + " " + lastName + " " + "Favorite color is" + " " + favoriteColour;      
        }



        public Person(int Id, string firstName , string LastName, string favoriteColor, int age, bool isWorking)
        {
            this.personId = Id;
            this.firstName = firstName;
            this.lastName = LastName;
            this.favoriteColour = favoriteColor;
            this.age = age;
            this.isWorking = true; 
        }

       
            


        
    }


}
