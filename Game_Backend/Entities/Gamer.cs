﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Game_Backend
{
    class Gamer
    {
        public int Id { get; set; }

        public string NationalityId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime DateofBirth { get; set; }
    }
}
