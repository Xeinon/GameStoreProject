using System;
using System.Collections.Generic;
using System.Text;
using GameProject.Abstract;


namespace GameProject.Entities
{
    public class Gamer
    {
        public int Id { get; set; }
        public long TcNo { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int DateOfBirth { get; set; }


    }
}
